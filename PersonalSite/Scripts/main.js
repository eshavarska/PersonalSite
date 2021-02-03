$(document).ready(function() {
    $(function() {
        var max_height = $('#work_experience');
        
    });

    $("#menu_btn").click(function() {
        $(".btn").toggleClass('active');
    });    

    $("#feedback_btn").click(function(){
        var elmnt = document.getElementById("feedback");
        elmnt.scrollIntoView({behavior: "smooth", block: "end", inline: "nearest"});
        $("#menu_btn").click();
    });

});



