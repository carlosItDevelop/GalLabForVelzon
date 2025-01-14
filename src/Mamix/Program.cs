using CurrieTechnologies.Razor.SweetAlert2;
using mamix.Data;
using mamix.Services.Categorias;
using mamix.Services.Clientes;
using mamix.Services.Pedidos;
using mamix.Services.Produtos;
using mamix.Services.Vendedores;
using Microsoft.AspNetCore.Authentication.Cookies;
using Soenneker.Blazor.FilePond.Registrars;
using Soenneker.Blazor.TomSelect.Registrars;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<StateService>();
builder.Services.AddSingleton<AppState>();
builder.Services.AddScoped<IActionService, ActionService>();
builder.Services.AddFilePond();
builder.Services.AddTomSelect();
builder.Services.AddWMBOS();
builder.Services.AddWMBSC(); 
builder.Services.AddSweetAlert2();
builder.Services.AddScoped<CartListService>();
builder.Services.AddScoped<CrmContactsService>();
builder.Services.AddScoped<CrmCompaniesService>();
builder.Services.AddScoped<CrmLeadsService>();
builder.Services.AddScoped<InvoiceService>();
builder.Services.AddScoped<TaskListService>();
builder.Services.AddScoped<TransactionService>();
builder.Services.AddScoped<MenuDataService>();
builder.Services.AddScoped<EcommerceMenuDataService>();
builder.Services.AddScoped<ClassifiedsMenuDataService>();
builder.Services.AddScoped<DomainMenuDataService>();
builder.Services.AddScoped<NestedModel>();
builder.Services.AddScoped<MarketplaceMenuDataService>();
builder.Services.AddScoped<RealestateMenuDataService>();
builder.Services.AddScoped<NavScrollService>();
builder.Services.AddSession();
builder.Services.AddScoped<SessionService>();

// Add session services
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Adjust timeout as needed
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/login";
        options.AccessDeniedPath = "/accessdenied";
        options.Cookie.Name = "YourAppCookieName";
        options.Cookie.HttpOnly = true;
        options.Cookie.SameSite = SameSiteMode.Strict;
        options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    });


// Registro do HttpClient
builder.Services.AddHttpClient("CadastroApi", client =>
{
    client.BaseAddress = new Uri("https://localhost:7009"); // URL da API de Cadastro
});


builder.Services.AddHttpClient("IdentidadeApi", client =>
{
    client.BaseAddress = new Uri("https://localhost:5013"); // URL da API Identidade
});

builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IVendedorService, VendedorService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseSession();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();

app.UseAuthentication();
app.UseAuthorization();

// Map fallback route for Classifieds pages
app.MapFallbackToPage("/classifieds-details", "/_LandingHost");
app.MapFallbackToPage("/classifieds-landing", "/_LandingHost");
app.MapFallbackToPage("/classifieds-search", "/_LandingHost");

// Map fallback route for Domain pages
app.MapFallbackToPage("/domain-details", "/_LandingHost");
app.MapFallbackToPage("/domain-landing", "/_LandingHost");
app.MapFallbackToPage("/domain-single-landing", "/_SingleLandingHost");

// Map fallback route for Marketplace pages
app.MapFallbackToPage("/marketplace-details", "/_LandingHost");
app.MapFallbackToPage("/marketplace-landing", "/_LandingHost");
app.MapFallbackToPage("/marketplace-search", "/_LandingHost");
app.MapFallbackToPage("/marketplace-user", "/_LandingHost");
app.MapFallbackToPage("/marketplace-user-public-profile", "/_LandingHost");
app.MapFallbackToPage("/marketplace-vendor", "/_LandingHost");

// Map fallback route for Realestate pages
app.MapFallbackToPage("/realestate-details", "/_LandingHost");
app.MapFallbackToPage("/realestate-landing", "/_LandingHost");
app.MapFallbackToPage("/realestate-search", "/_LandingHost");
app.MapFallbackToPage("/realestate-user-public-profile", "/_LandingHost");
app.MapFallbackToPage("/realestate-user", "/_RealestateHost");
app.MapFallbackToPage("/realestate-vendor", "/_RealestateHost");

// Map fallback route for Ecommerce pages
app.MapFallbackToPage("/ecommerce-aboutus", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-contactus", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-customer", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-customer-address", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-customer-cart", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-customer-checkout", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-customer-compare", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-customer-coupons", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-customer-ordertracking", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-customer-refunds", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-customer-settings", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-customer-wishlist", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-details", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-landing", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-privacy-policies", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-search", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-terms-conditions", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-vendor", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-vendor-addproduct", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-vendor-invoicedetails", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-vendor-invoices", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-vendor-orders", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-vendor-packages", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-vendor-public-profile", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-vendor-refunds", "/_EcommerceHost");
app.MapFallbackToPage("/ecommerce-vendor-settings", "/_EcommerceHost");


// Map fallback route for All Custom pages
app.MapFallbackToPage("/comingsoon", "/_CustomHost");
app.MapFallbackToPage("/createpassword-basic", "/_CustomHost");
app.MapFallbackToPage("/createpassword-cover", "/_CustomHost");
app.MapFallbackToPage("/lockscreen-basic", "/_CustomHost");
app.MapFallbackToPage("/lockscreen-cover", "/_CustomHost");
app.MapFallbackToPage("/resetpassword-basic", "/_CustomHost");
app.MapFallbackToPage("/resetpassword-cover", "/_CustomHost");
app.MapFallbackToPage("/signin-basic", "/_CustomHost");
app.MapFallbackToPage("/signin-cover", "/_CustomHost");
app.MapFallbackToPage("/signup-basic", "/_CustomHost");
app.MapFallbackToPage("/signup-cover", "/_CustomHost");
app.MapFallbackToPage("/twostep-verification-basic", "/_CustomHost");
app.MapFallbackToPage("/twostep-verification-cover", "/_CustomHost");
app.MapFallbackToPage("/under-maintenance", "/_CustomHost");
app.MapFallbackToPage("/error401", "/_CustomHost");
app.MapFallbackToPage("/error404", "/_CustomHost");
app.MapFallbackToPage("/error500", "/_CustomHost");


app.MapFallbackToPage("/_Host");

app.Run();
