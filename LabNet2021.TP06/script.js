"use strict";

$(document).ready(function()
{
    $('#submit').click(function()
    {
        if (!$('#txtNombre').val())
        {
            alert('INGRESE SU NOMBRE');
        }
        else if (!$('#txtApellido').val())
        {
            alert('INGRESE SU APELLIDO');
        }      
    })

    $("#clean").click(function()
    {
        $('#form').find('input:text').val('');
        $("input[type=number]").val('');
        if($("input:radio[name=sexo]").is(':checked')) 
        {
            $("input:radio[name=sexo]:checked")[0].checked = false;
        }
    }) 
});
