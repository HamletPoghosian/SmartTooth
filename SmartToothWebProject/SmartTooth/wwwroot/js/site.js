// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
<script type="text/javascript">
    $(document).ready(function(){
        var boxWidth = $(".box").width();
		$(".box").mouseenter(function(){
        $(this).animate({
            width: "400"
        });
    }).mouseleave(function(){
        $(this).animate({
            width: boxWidth
        });
    });
});
</script>