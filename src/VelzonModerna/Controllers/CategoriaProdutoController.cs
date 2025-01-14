using AutoMapper;
using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Interfaces;
using GeneralLabSolutions.Domain.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VelzonModerna.ViewModels;

namespace VelzonModerna.Controllers
{
    //[Authorize]
    public class CategoriaProdutoController : Controller
    {

        private readonly IMapper _mapper;

        private readonly ICategoriaRepository _categoriaRepository;
        private readonly ICategoriaDomainService _categoriaDomainService;
        private readonly IQueryGenericRepository<CategoriaProduto, Guid> _query;


        public CategoriaProdutoController(IMapper mapper, 
                            ICategoriaRepository categoriaRepository, 
                            ICategoriaDomainService categoriaDomainService,         IQueryGenericRepository<CategoriaProduto, Guid> query)
        {
            _mapper = mapper;
            _categoriaRepository = categoriaRepository;
            _categoriaDomainService = categoriaDomainService;
            _query = query;
        }

        //[AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var listaCategoriaProdutoViewModel 
                = _mapper.Map<IEnumerable<CategoriaProdutoViewModel>>(await _query.GetAllAsync());

            return View(listaCategoriaProdutoViewModel);
        }

        // GET: CategoriaProduto/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var categoriaProdutoViewModel
                = _mapper.Map<CategoriaProdutoViewModel>(await _query.GetByIdAsync(id));

            if (categoriaProdutoViewModel == null)
            {
                return NotFound();
            }


            return View(categoriaProdutoViewModel);
        }

        // GET: CategoriaProduto/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoriaProdutoViewModel CategoriaViewModel)
        {
            if (ModelState.IsValid)
            {
                await _categoriaDomainService.AddCategoriaAsync(_mapper.Map<CategoriaProduto>(CategoriaViewModel));

                await _categoriaRepository.UnitOfWork.CommitAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(CategoriaViewModel);
        }

        // GET: CategoriaProduto/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {

            var categoriaProdutoViewModel
                = _mapper.Map<CategoriaProdutoViewModel>(await _query.GetByIdAsync(id));

            if (categoriaProdutoViewModel == null)
            {
                return NotFound();
            }
            return View(categoriaProdutoViewModel);
        }

        // POST: CategoriaProduto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, CategoriaProdutoViewModel categoriaViewModel)
        {
            if (id != categoriaViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _categoriaDomainService.UpdateCategoriaAsync(_mapper.Map<CategoriaProduto>(categoriaViewModel));

                    await _categoriaRepository.UnitOfWork.CommitAsync();
                    
                } catch (DbUpdateConcurrencyException)
                {
                    if (!await CategotiaExists(categoriaViewModel.Id))
                    {
                        return NotFound();
                    } else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaViewModel);
        }

        // GET: CategoriaProduto/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {


            var categoria
                = await _query.GetByIdAsync(id);

            if (categoria == null)
            {
                return NotFound("Categoria não encontrada!");
            }

            return View(_mapper.Map<CategoriaProdutoViewModel>(await _query.GetByIdAsync(id)));
        }

        // POST: CategoriaProduto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var categoria = await _query.GetByIdAsync(id);

            if (categoria == null)
            {
                return NotFound("Categoria não encontrada!");
            }
            await _categoriaDomainService.DeleteCategoriaProdutoAsync(categoria);
            await _categoriaRepository.UnitOfWork.CommitAsync();
            return RedirectToAction(nameof(Index));

        }

        private async Task<bool> CategotiaExists(Guid id)
        {
            return await _categoriaRepository.TemCategoria(id);

        }
    }
}