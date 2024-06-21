$(document).ready(function() {
    function ExibirTarefas() {
        var strText = "";

        if (localStorage.length == 0) {
            alert('Não há nada cadastrado');
        } else {
            for (let i = 0; i < localStorage.length; i++) {
                const key = localStorage.key(i);
                const value = localStorage.getItem(key);
                strText += `<p><input type="checkbox" id="${key}"> ${value}</p>`;
            }

            $("#listaTarefas").html(strText);
        }
    }

    function CadastrarTarefa() {
        var strItem = $("#newItem").val();
        if (strItem) {
            var key = `tarefa_${Date.now()}`;
            localStorage.setItem(key, strItem);
            $("#newItem").val(''); 
            
        } else {
            alert('Por favor, insira uma tarefa.');
        }
    }

    function DeletarTarefa() {
        $("input[type='checkbox']").change(function() {
            if ($(this).is(":checked")) {
                var idCheckbox = this.id;
                if (localStorage.getItem(idCheckbox)) {
                    localStorage.removeItem(idCheckbox);
                }
            }
        });
    }

    function ConcluirTarefa() {
        $("input[type='checkbox']").change(function() {
            var idCheckbox = this.id;

            if ($(this).is(":checked")) {
                var strTarefa = `<input type="checkbox" id="${idCheckbox}">${value}>`;
            } else {
                var strTarefa = `<input type="checkbox" id="${idCheckbox}">${value}`;
            }

            localStorage.setItem(idCheckbox, strTarefa);
            ExibirTarefas(); 
        });
    }

    $("#btnInserirItem").click(CadastrarTarefa);
    $("#btnListar").click(ExibirTarefas);
    $("#btnMarcar").click(ConcluirTarefa);

    $("#btnExcluir").click(DeletarTarefa);
    
});

