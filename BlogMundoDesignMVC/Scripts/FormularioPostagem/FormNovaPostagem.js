//campos
var nomeAutor = document.getElementById('NomeAutor');
var dataPostagem = document.getElementById('DataPostagem');
var tituloPostagem = document.getElementById('TituloPostagem');
var subtituloPostagem = document.getElementById('SubtituloPostagem');
var conteudoPrimeiroNivelPostagem = document.getElementById('ConteudoPrimeiroNivelPostagem');
var tituloMeioPostagem = document.getElementById('TituloMeioPostagem');
var conteudoSegundoNivelPostagem = document.getElementById('ConteudoSegundoNivelPostagem');

//botão

var btnNovaPostagem = document.getElementById('btnNovaPostagem');

btnNovaPostagem.addEventListener('click', function (event) {
    event.preventDefault();

    var data = {
        "ConteudoPrimeiroNivelPostagem": conteudoPrimeiroNivelPostagem.value,
        "ConteudoSegundoNivelPostagem": conteudoSegundoNivelPostagem.value,
        "DataPostagem": dataPostagem.value,
        "NomeAutor": nomeAutor.value,
        "SubtituloPostagem": subtituloPostagem.value,
        "TituloMeioPostagem": tituloMeioPostagem.value,
        "TituloPostagem": tituloPostagem.value,
        "ImagemPostBase64": "caminhoImagem",
        "FotoAutor": "fotoAutor"
    };
    

    jQuery.ajax({
        accept: "application/json",
        type: 'POST',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: "https://blogmundodesign.firebaseio.com/postagens.json",
        data: JSON.stringify(data)
    });

    //$.ajax({
    //    url: "https://blogmundodesign.firebaseio.com/postagens.json",
    //    type: "POST",
    //    data: {
    //        ConteudoPrimeiroNivelPostagem: conteudoPrimeiroNivelPostagem.value,
    //        ConteudoSegundoNivelPostagem: conteudoSegundoNivelPostagem.value,
    //        DataPostagem: dataPostagem.value,
    //        NomeAutor: nomeAutor.value,
    //        SubtituloPostagem: subtituloPostagem.value,
    //        TituloMeioPostagem: tituloMeioPostagem.value,
    //        TituloPostagem: tituloPostagem.value,
    //        ImagemPostBase64: " ",
    //        FotoAutor: " "
    //    },
    //    success: function(result) {
    //        alert("FÔE");
    //    },
    //    error: function (error) {
    //        console.error(error);
    //        alert('deu ruim jovem, chama o thiago');
    //    }

    //});


});