///*
//Template Name: Velzon - Admin & Dashboard Template
//Author: Themesbrand
//Co-Author: Cooperchip CPES Ltda.
//Website: https://Themesbrand.com/
//Contact: contato.cooperchip@gmail.com
//File: kanban-gl-solutions.init.js
//*/

//$(document).ready(function () {
//    // Variável global para armazenar o ID da tarefa em edição
//    var taskIdEmEdicao = null;

//    // Buscar os dados do servidor via AJAX
//    obterDadosKanban();

//    // Função para buscar os dados do Kanban do servidor
//    function obterDadosKanban() {
//        $.ajax({
//            url: '/Tarefas/ObterDadosKanban',
//            type: 'GET',
//            success: function (data) {
//                console.log("Dados recebidos do servidor:", data);
//                renderizarKanban(data);
//            },
//            error: function (error) {
//                console.error("Erro na requisição AJAX:", error);
//            }
//        });
//    }

//    // Função para renderizar o Kanban
//    function renderizarKanban(tarefas) {
//        var kanbanBoardContainer = $('#kanbanBoardContainer');

//        var kanbanHTML = `
//            <div class="tasks-board mb-3" id="kanbanboard">
//                ${renderizarListaTarefas('Unassigned', tarefas)}
//                ${renderizarListaTarefas('ToDo', tarefas)}
//                ${renderizarListaTarefas('Inprogress', tarefas)}
//                ${renderizarListaTarefas('InReviews', tarefas)}
//                ${renderizarListaTarefas('Completed', tarefas)}
//                ${renderizarListaTarefas('New', tarefas)}
//            </div>
//        `;

//        kanbanBoardContainer.html(kanbanHTML);
//        taskCounter();
//        inicializarDragula();
//    }

//    // Função para renderizar uma lista de tarefas
//    function renderizarListaTarefas(status, tarefas) {
//        var tarefasFiltradas = tarefas.filter(function (tarefa) {
//            return tarefa.status === status;
//        });

//        var cardsHTML = tarefasFiltradas.map(renderizarTarefa).join('');

//        return `
//            <div class="tasks-list">
//                <div class="d-flex mb-3">
//                    <div class="flex-grow-1">
//                        <h6 class="fs-14 text-uppercase fw-semibold mb-0">
//                            ${status} <small class="badge bg-danger align-bottom ms-1 totaltask-badge">0</small>
//                        </h6>
//                    </div>
//                </div>
//                <div data-simplebar class="tasks-wrapper px-3 mx-n3">
//                    <div id="${status.toLowerCase().replaceAll(" ", "-")}-task" class="tasks">
//                        ${cardsHTML}
//                    </div>
//                </div>
//                <div class="my-3">
//                    <button class="btn btn-soft-info w-100" data-bs-toggle="modal" data-bs-target="#creatertaskModal" data-status="${status}">
//                        Add More
//                    </button>
//                </div>
//            </div>
//        `;
//    }

//    // Função para renderizar o HTML de uma tarefa
//    function renderizarTarefa(tarefa) {
//        return `
//            <div class="card tasks-box" data-task-id="${tarefa.id}">
//                <div class="card-body">
//                    <div class="d-flex mb-2">
//                        <h6 class="fs-16 mb-0 flex-grow-1 text-truncate task-title">
//                            <a href="/Tarefas/TaskDetails/${tarefa.id}" class="text-body d-block">
//                                ${tarefa.titulo}
//                            </a>
//                        </h6>
//                        <div class="dropdown">
//                            <a href="javascript:void(0);" class="text-muted" data-bs-toggle="dropdown" aria-expanded="false"><i class="ri-more-fill"></i></a>
//                            <ul class="dropdown-menu">
//                                <li>
//                                    <a class="dropdown-item" href="/Tarefas/TaskDetails/${tarefa.id}">
//                                        <i class="ri-eye-fill align-bottom me-2 text-muted"></i>
//                                        View
//                                    </a>
//                                </li>
//                                <li>
//                                    <a class="dropdown-item" href="#" onclick="abrirModalEdicao('${tarefa.id}')">
//                                        <i class="ri-edit-2-line align-bottom me-2 text-muted"></i>
//                                        Edit
//                                    </a>
//                                </li>
//                                <li>
//                                    <a class="dropdown-item" data-bs-toggle="modal" href="#deleteRecordModal" data-bs-whatever="${tarefa.id}">
//                                        <i class="ri-delete-bin-5-line align-bottom me-2 text-muted"></i>
//                                        Delete
//                                    </a>
//                                </li>
//                            </ul>
//                        </div>
//                    </div>
//                    <p class="text-muted">${tarefa.descricao}</p>
//                </div>
//            </div>
//        `;
//    }

//    function inicializarDragula() {
//        var tasks_list = [
//            document.getElementById("kanbanboard"),
//            document.getElementById("unassigned-task"),
//            document.getElementById("todo-task"),
//            document.getElementById("inprogress-task"),
//            document.getElementById("inreviews-task"),
//            document.getElementById("completed-task"),
//            document.getElementById("new-task")
//        ];

//        drake = dragula(tasks_list)
//            .on('drag', function (el, source) {
//                el.className = el.className.replace('ex-moved', '');
//            })
//            .on('drop', function (el, target, source, sibling) {
//                el.className += ' ex-moved';

//                var taskId = el.getAttribute('data-task-id');
//                var novoStatus = obterStatusDaLista(target.id);

//                atualizarStatusTarefa(taskId, novoStatus);

//                noTaskImage();
//                taskCounter();
//            })
//            .on('over', function (el, container) {
//                container.className += ' ex-over';
//            })
//            .on('out', function (el, container) {
//                container.className = container.className.replace('ex-over', '');
//            });
//    }

//    // Função para obter o status da lista com base no ID do elemento
//    function obterStatusDaLista(listaId) {
//        switch (listaId) {
//            case 'unassigned-task':
//                return 'Unassigned';
//            case 'todo-task':
//                return 'ToDo';
//            case 'inprogress-task':
//                return 'Inprogress';
//            case 'reviews-task':
//                return 'InReviews';
//            case 'completed-task':
//                return 'Completed';
//            case 'new-task':
//                return 'New';
//            default:
//                return ''; // Ou lance um erro se o ID for inválido
//        }
//    }

//    // Função para atualizar o status da tarefa via AJAX
//    function atualizarStatusTarefa(taskId, novoStatus) {
//        $.ajax({
//            url: '/Tarefas/AtualizarStatusTarefa',
//            type: 'POST',
//            contentType: 'application/json',
//            data: JSON.stringify({
//                id: taskId,
//                status: novoStatus
//            }),
//            success: function (response) {
//                console.log("Status da tarefa atualizado com sucesso!", response);
//            },
//            error: function (error) {
//                console.error("Erro ao atualizar o status da tarefa:", error);
//            }
//        });
//    }

//    // Função para mostrar/esconder a imagem "No Task"
//    function noTaskImage() {
//        Array.from(document.querySelectorAll("#kanbanboard .tasks-list")).forEach(function (item) {
//            var taskBox = item.querySelectorAll(".tasks-box");
//            if (taskBox.length > 0) {
//                item.querySelector('.tasks').classList.remove("noTask");
//            } else {
//                item.querySelector('.tasks').classList.add("noTask");
//            }
//        });
//    }


//    // Função renderTask
//    function renderTask(task) {
//        // Formatar a data de vencimento
//        var dataVencimentoFormatada = new Date(task.dataVencimento).toLocaleDateString(); // Ajustar o formato conforme necessário

//        return `
//        <div class="card tasks-box" data-task-id="${task.id}">
//            <div class="card-body">
//                <div class="d-flex mb-2">
//                    <h6 class="fs-16 mb-0 flex-grow-1 text-truncate task-title">
//                        <a href="javascript:void(0);" class="text-body d-block">
//                            ${task.titulo}
//                        </a>
//                    </h6>
//                    <div class="dropdown">
//                        <a href="javascript:void(0);" class="text-muted" data-bs-toggle="dropdown" aria-expanded="false"><i class="ri-more-fill"></i></a>
//                        <ul class="dropdown-menu">
//                            <li>
//                                <a class="dropdown-item" href="javascript:void(0);">
//                                    <i class="ri-eye-fill align-bottom me-2 text-muted"></i> View
//                                </a>
//                            </li>
//                            <li>
//                                <a class="dropdown-item" href="javascript:void(0);">
//                                    <i class="ri-edit-2-line align-bottom me-2 text-muted"></i> Edit
//                                </a>
//                            </li>
//                            <li>
//                                <a class="dropdown-item" data-bs-toggle="modal" href="#deleteRecordModal">
//                                    <i class="ri-delete-bin-5-line align-bottom me-2 text-muted"></i> Delete
//                                </a>
//                            </li>
//                        </ul>
//                    </div>
//                </div>
//                <p class="text-muted">${task.descricao}</p>
//                <p class="text-muted">Status: ${task.status}</p> <p class="text-muted">Data de Vencimento: ${dataVencimentoFormatada}</p> </div> </div>
//    `;
//    }


//    // Função para atualizar o contador de tarefas nas colunas
//    function taskCounter() {
//        task_lists = document.querySelectorAll("#kanbanboard .tasks-list");
//        if (task_lists) {
//            Array.from(task_lists).forEach(function (element) {
//                tasks = element.getElementsByClassName("tasks");
//                Array.from(tasks).forEach(function (ele) {
//                    task_box = ele.getElementsByClassName("tasks-box");
//                    task_counted = task_box.length;
//                });
//                badge = element.querySelector(".totaltask-badge").innerText = "";
//                badge = element.querySelector(".totaltask-badge").innerText = task_counted;
//            });
//        }
//    };



//	    //Create a new kanban board
//    var addNewBoard = document.getElementById('addNewBoard');
//    if (addNewBoard) {
//        document.getElementById("addNewBoard").addEventListener("click", newKanbanbaord);

//        function newKanbanbaord() {
//            var boardName = document.getElementById("boardName").value;
//            var uniqueid = Math.floor(Math.random() * 100);
//            var randomid = "remove_item_" + uniqueid;
//            var dragullaid = "review_task_" + uniqueid;
//            kanbanlisthtml =
//                '<div class="tasks-list" id=' +
//                randomid +
//                ">" +
//                '<div class="d-flex mb-3">' +
//                '<div class="flex-grow-1">' +
//                '<h6 class="fs-14 text-uppercase fw-semibold mb-0">' +
//                boardName +'<small class="badge bg-success align-bottom ms-1 totaltask-badge">0</small></h6>' +
//                '</div>' +
//                '<div class="flex-shrink-0">' +
//                '<div class="dropdown card-header-dropdown">' +
//                '<a class="text-reset dropdown-btn" href="#" data-bs-toggle="dropdown" aria-haspopup="true" aria-expanded="false">' +
//                '<span class="fw-medium text-muted fs-12">Priority<i class="mdi mdi-chevron-down ms-1"></i></span>' +
//                '</a>' +
//                '<div class="dropdown-menu dropdown-menu-end">' +
//                '<a class="dropdown-item" href="#">Priority</a>' +
//                '<a class="dropdown-item" href="#">Date Added</a>' +
//                '</div>' +
//                '</div>' +
//                '</div>' +
//                '</div>' +
//                '<div data-simplebar class="tasks-wrapper px-3 mx-n3">' +
//                '<div class="tasks" id="' + dragullaid + '" >' +
//                '</div>' +
//                '</div>' +
//                '<div class="my-3">' +
//                '<button class="btn btn-soft-info w-100" data-bs-toggle="modal" data-bs-target="#creatertaskModal">Add More</button>' +
//                '</div>' +
//                '</div>';

//            var subTask = document.getElementById("kanbanboard");
//            subTask.insertAdjacentHTML("beforeend", kanbanlisthtml);

//            var link = document.getElementById("addBoardBtn-close");
//            link.click();

//            noTaskImage();
//            taskCounter()

//            drake.destroy();
//            tasks_list.push(document.getElementById(dragullaid));
//            drake = dragula(tasks_list).on('out', function (el, container) {
//                noTaskImage();
//                taskCounter()
//            });
//            document.getElementById("boardName").value = "";
//        }
//    };



//    // Delegar o evento de clique para o container do Kanban
//    $('#kanbanBoardContainer').on('click', '.btn-soft-info', function () {
//        var statusLista = $(this).data('status');

//        // Armazenar o status da lista em um atributo data do modal
//        $('#creatertaskModal').data('status-lista', statusLista);

//        console.log("Status da Lista:", statusLista);
//    });

//    /// Vincular o evento de clique ao botão "Adicionar"
//    $('#btnAdicionarTarefa').on('click', function (event) {
//        event.preventDefault();

//        var statusLista = $('#creatertaskModal').data('status-lista');
//        console.log("Status da lista ao submeter:", statusLista);

//        // Obter os dados do formulário (incluindo o status da lista)
//        var novaTarefa = {
//            titulo: $('#sub-tasks').val(),
//            descricao: $('#task-description').val(),
//            dataVencimento: $('#due-date').val(), // Certifique-se de que este campo está no formato correto
//            status: statusLista
//        };

//        criarTarefa(novaTarefa);
//    });


//    var token = $('input[name="__RequestVerificationToken"]').val();


//    function criarTarefa(novaTarefa) {
//        console.log('Dados da nova tarefa:', novaTarefa); // Adicione esta linha para depurar

//        // Enviar os dados para a action CriarTarefa via AJAX
//        $.ajax({
//            url: '/Tarefas/CriarTarefa',
//            type: 'POST',
//            contentType: 'application/json', // Adicionar esta linha!
//            headers: {
//                'RequestVerificationToken': token
//            },
//            data: JSON.stringify(novaTarefa), // Converter os dados para uma string JSON
//            success: function (response) {
//                // Fechar o modal
//                $('#creatertaskModal').modal('hide');

//                // Renderizar a nova tarefa no Kanban, na lista correta
//                var novaTarefaHtml = renderTask(response.tarefa);
//                $(`#${response.status.toLowerCase().replaceAll(" ", "-")}-task .tasks`).append(novaTarefaHtml);

//                // Atualizar os contadores de tarefas
//                taskCounter();
//            },
//            error: function (xhr, status, error) {
//                console.error('Erro ao criar a tarefa:', error);
//                console.error('Resposta do servidor:', xhr.responseText);
//                // Exibir uma mensagem de erro para o usuário
//                // ...
//            }
//        });
//    };



//	// Add Members
//    var addMember = document.getElementById('addMember');
//    if (addMember) {
//        document.getElementById("addMember").addEventListener("click", newMemberAdd);

//        //set membar profile
//        var profileField = document.getElementById("profileimgInput");
//        var reader = new FileReader();
//        profileField.addEventListener("change", function (e) {
//            reader.readAsDataURL(profileField.files[0]);
//            reader.onload = function () {
//                var imgurl = reader.result;
//                var dataURL = '<img src="' + imgurl + '" alt="profile" class="rounded-circle avatar-xs">';
//                localStorage.setItem('kanbanboard-member', dataURL);
//            };
//        });

//        function newMemberAdd() {
//            var firstName = document.getElementById("firstnameInput").value;
//            var getMemberProfile = localStorage.getItem('kanbanboard-member');

//            newMembar = '<a href="javascript: void(0);" class="avatar-group-item" data-bs-toggle="tooltip" data-bs-trigger="hover" data-bs-placement="top" title="' + firstName + '">' + getMemberProfile + '</a>';

//            var subMemberAdd = document.getElementById("newMembar");
//            subMemberAdd.insertAdjacentHTML("afterbegin", newMembar);

//            var link = document.getElementById("btn-close-member");
//            link.click();
//        }
//    };



//    // Função para abrir o modal de edição
//    function abrirModalEdicao(taskId) {
//        taskIdEmEdicao = taskId;
//        console.log('ID da tarefa em edição:', taskIdEmEdicao);

//        $('#addmemberModal').modal('show');
//    };


//    // Expor a função abrirModalEdicao para ser usada no HTML (onclick)
//    window.abrirModalEdicao = abrirModalEdicao;
//});


/*
Template Name: Velzon - Admin & Dashboard Template
Author: Themesbrand
Co-Author: Cooperchip CPES Ltda.
Website: https://Themesbrand.com/
Contact: contato.cooperchip@gmail.com
File: kanban-gl-solutions.init.js
*/

$(document).ready(function () {
    // Variável global para armazenar o ID da tarefa em edição
    let taskIdEmEdicao = null;

    // Inicializar o Kanban
    inicializarKanban();

    function inicializarKanban() {
        obterDadosKanban();
        configurarEventos();
    }

    // Função para buscar os dados do Kanban do servidor
    async function obterDadosKanban() {
        try {
            const response = await fetch('/Tarefas/ObterDadosKanban');
            const data = await response.json();
            console.log("Dados recebidos do servidor:", data);
            renderizarKanban(data);
        } catch (error) {
            console.error("Erro na requisição:", error);
        }
    }

    // Função para renderizar o Kanban
    function renderizarKanban(tarefas) {
        const kanbanBoardContainer = $('#kanbanBoardContainer');
        kanbanBoardContainer.html(gerarKanbanHTML(tarefas));
        taskCounter();
        inicializarDragula();
    }

    // Função para gerar o HTML do Kanban
    function gerarKanbanHTML(tarefas) {
        const estados = ['Unassigned', 'ToDo', 'Inprogress', 'InReviews', 'Completed', 'New'];
        return `
            <div class="tasks-board mb-3" id="kanbanboard">
                ${estados.map(status => renderizarListaTarefas(status, tarefas)).join('')}
            </div>
        `;
    }

    // Função para renderizar uma lista de tarefas
    function renderizarListaTarefas(status, tarefas) {
        const tarefasFiltradas = tarefas.filter(tarefa => tarefa.status === status);
        const cardsHTML = tarefasFiltradas.map(renderizarTarefa).join('');

        return `
            <div class="tasks-list">
                <div class="d-flex mb-3">
                    <div class="flex-grow-1">
                        <h6 class="fs-14 text-uppercase fw-semibold mb-0">
                            ${status} <small class="badge bg-danger align-bottom ms-1 totaltask-badge">0</small>
                        </h6>
                    </div>
                </div>
                <div data-simplebar class="tasks-wrapper px-3 mx-n3">
                    <div id="${status.toLowerCase().split(" ").join("-")}-task" class="tasks">
                        ${cardsHTML}
                    </div>
                </div>
                <div class="my-3">
                    <button class="btn btn-soft-info w-100" data-bs-toggle="modal" data-bs-target="#creatertaskModal" data-status="${status}">
                        Add More
                    </button>
                </div>
            </div>
        `;
    }

    // Função para renderizar o HTML de uma tarefa
    function renderizarTarefa(tarefa) {
        return `
            <div class="card tasks-box" data-task-id="${tarefa.id}">
                <div class="card-body">
                    <div class="d-flex mb-2">
                        <h6 class="fs-16 mb-0 flex-grow-1 text-truncate task-title">
                            <a href="/Tarefas/TaskDetails/${tarefa.id}" class="text-body d-block">
                                ${tarefa.titulo}
                            </a>
                        </h6>
                        <div class="dropdown">
                            <a href="javascript:void(0);" class="text-muted" data-bs-toggle="dropdown" aria-expanded="false"><i class="ri-more-fill"></i></a>
                            <ul class="dropdown-menu">
                                <li>
                                    <a class="dropdown-item" href="/Tarefas/TaskDetails/${tarefa.id}">
                                        <i class="ri-eye-fill align-bottom me-2 text-muted"></i>
                                        View
                                    </a>
                                </li>
                                <li>
                                    <a class="dropdown-item editar-tarefa" href="#" data-task-id="${tarefa.id}">
                                        <i class="ri-edit-2-line align-bottom me-2 text-muted"></i>
                                        Edit
                                    </a>
                                </li>
                                <li>
                                    <a class="dropdown-item" data-bs-toggle="modal" href="#deleteRecordModal" data-bs-whatever="${tarefa.id}">
                                        <i class="ri-delete-bin-5-line align-bottom me-2 text-muted"></i>
                                        Delete
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <p class="text-muted">${tarefa.descricao}</p>
                </div>
            </div>
        `;
    }

    function inicializarDragula() {
        const tasks_list = obterElementosTarefas();

        let drake = dragula(tasks_list)
            .on('drag', function (el) {
                el.classList.remove('ex-moved');
            })
            .on('drop', function (el, target) {
                el.classList.add('ex-moved');

                const taskId = el.getAttribute('data-task-id');
                const novoStatus = obterStatusDaLista(target.id);

                atualizarStatusTarefa(taskId, novoStatus);

                noTaskImage();
                taskCounter();
            })
            .on('over', function (el, container) {
                container.classList.add('ex-over');
            })
            .on('out', function (el, container) {
                container.classList.remove('ex-over');
            });
    }

    // Função para obter os elementos de tarefas do Kanban
    function obterElementosTarefas() {
        return [
            document.getElementById("kanbanboard"),
            document.getElementById("unassigned-task"),
            document.getElementById("todo-task"),
            document.getElementById("inprogress-task"),
            document.getElementById("inreviews-task"),
            document.getElementById("completed-task"),
            document.getElementById("new-task")
        ];
    }

    // Função para obter o status da lista com base no ID do elemento
    function obterStatusDaLista(listaId) {
        const statusMap = {
            'unassigned-task': 'Unassigned',
            'todo-task': 'ToDo',
            'inprogress-task': 'Inprogress',
            'reviews-task': 'InReviews',
            'completed-task': 'Completed',
            'new-task': 'New'
        };
        return statusMap[listaId] || '';
    }

    // Função para atualizar o status da tarefa via AJAX
    async function atualizarStatusTarefa(taskId, novoStatus) {
        try {
            const response = await fetch('/Tarefas/AtualizarStatusTarefa', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({ id: taskId, status: novoStatus })
            });
            const result = await response.json();
            console.log("Status da tarefa atualizado com sucesso!", result);
        } catch (error) {
            console.error("Erro ao atualizar o status da tarefa:", error);
        }
    }

    // Função para mostrar/esconder a imagem "No Task"
    function noTaskImage() {
        document.querySelectorAll("#kanbanboard .tasks-list").forEach(item => {
            const taskBox = item.querySelectorAll(".tasks-box");
            item.querySelector('.tasks').classList.toggle("noTask", taskBox.length === 0);
        });
    }

    // Função para atualizar o contador de tarefas nas colunas
    function taskCounter() {
        document.querySelectorAll("#kanbanboard .tasks-list").forEach(element => {
            const task_counted = element.querySelectorAll(".tasks-box").length;
            element.querySelector(".totaltask-badge").innerText = task_counted;
        });
    }

    // Configurar eventos para interação do usuário
    function configurarEventos() {
        // Delegar o evento de clique para o container do Kanban
        $('#kanbanBoardContainer').on('click', '.btn-soft-info', function () {
            const statusLista = $(this).data('status');
            $('#creatertaskModal').data('status-lista', statusLista);
            console.log("Status da Lista:", statusLista);
        });

        // Vincular o evento de clique ao botão "Adicionar"
        $('#btnAdicionarTarefa').on('click', function (event) {
            event.preventDefault();
            const statusLista = $('#creatertaskModal').data('status-lista');
            console.log("Status da lista ao submeter:", statusLista);

            // Obter os dados do formulário (incluindo o status da lista)
            const novaTarefa = obterDadosFormularioTarefa(statusLista);
            criarTarefa(novaTarefa);
        });
    }

    // Função para obter os dados do formulário de tarefa
    function obterDadosFormularioTarefa(statusLista) {
        return {
            titulo: $('#sub-tasks').val(),
            descricao: $('#task-description').val(),
            dataVencimento: $('#due-date').val(),
            status: statusLista
        };
    }

    const token = $('input[name="__RequestVerificationToken"]').val();

    // Função para criar uma nova tarefa via AJAX
    async function criarTarefa(novaTarefa) {
        try {
            const response = await fetch('/Tarefas/CriarTarefa', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                    'RequestVerificationToken': token
                },
                body: JSON.stringify(novaTarefa)
            });
            const result = await response.json();

            // Fechar o modal
            $('#creatertaskModal').modal('hide');

            // Renderizar a nova tarefa no Kanban, na lista correta
            adicionarNovaTarefaAoKanban(result);

            // Atualizar os contadores de tarefas
            taskCounter();
        } catch (error) {
            console.error('Erro ao criar a tarefa:', error);
        }
    }

    // Função para adicionar uma nova tarefa ao Kanban
    function adicionarNovaTarefaAoKanban(result) {
        const novaTarefaHtml = renderizarTarefa(result.tarefa);
        $(`#${result.status.toLowerCase().split(" ").join("-")}-task .tasks`).append(novaTarefaHtml);
    }

    // Função para abrir o modal de edição
    function abrirModalEdicao(taskId) {
        taskIdEmEdicao = taskId;
        console.log('ID da tarefa em edição:', taskIdEmEdicao);
        $('#addmemberModal').modal('show');
    }

    // Expor a função abrirModalEdicao para ser usada no HTML (onclick)
    window.abrirModalEdicao = abrirModalEdicao;
});