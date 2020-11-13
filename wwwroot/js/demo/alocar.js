var enderecoVaga = "https://localhost:5001/Alocacao/VerAlocacao/1"

$("#vagaSelecionada").click(function() {
    var vaga = $("Vaga").val();
    var enderecoId = enderecoVaga+vaga;
    $.post(enderecoId, function(dados, status){
        alert ("Dados: " + dados + " Status: " + status);
    });

 }); 

