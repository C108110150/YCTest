$(function () {
    $('.toggleFooter').on('click', function () {
        $(".mainFooter").slideToggle("slow");
        $(".fa-chevron-up").toggleClass('show');
    });

});