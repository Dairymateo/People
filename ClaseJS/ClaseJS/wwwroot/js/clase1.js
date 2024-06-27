

var contador = 0;

$(document).ready(function () {
    
    $("#boton1").on("click", function () {
        contador = contador + 1;
        alert("Acabo de hacer un click numero: " +contador);
        //document.getElementById("texto_clicks").innerHTML="Numero de clicks: " + contador;
        //$("#texto_clicks").html("Numero de clicks xd:" + contador);
       
    });
})      





function alertaClick() {
    contador = contador++;
    alert("Acabo de hacer un click numero: " +contador);
}