
$("input[name*='txtPhone']").mask('(000)0000-0000');
$("input[name*='txtPhone']").prop('placeholder', '(503)7878-7878');
$("input").prop('required', true);


$(".cla_cancelar").on('click', function (e) {
    e.preventDefault();
    
    window.location.href = "Employees";
});


