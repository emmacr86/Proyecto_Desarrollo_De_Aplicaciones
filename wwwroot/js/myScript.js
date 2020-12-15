function disable() {
    document.getElementById("nombre").disabled = true;
    document.getElementById("apellido1").disabled = true;
    document.getElementById("apellido2").disabled = true;
    document.getElementById("telefono").disabled = true;
    document.getElementById("direccion").disabled = true;
    document.getElementById("salvar").hidden = true;
    document.getElementById("cancelar").hidden = true;
    document.getElementById("editar").hidden = false;
}
function enable() {
    document.getElementById("nombre").disabled = false;
    document.getElementById("apellido1").disabled = false;
    document.getElementById("apellido2").disabled = false;
    document.getElementById("telefono").disabled = false;
    document.getElementById("direccion").disabled = false;
    document.getElementById("salvar").hidden = false;
    document.getElementById("cancelar").hidden = false;
    document.getElementById("editar").hidden = true;
}