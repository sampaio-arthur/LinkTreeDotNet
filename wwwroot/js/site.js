// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
<script>
    document.addEventListener('mousemove', function(e) {
        console.log('Mouse move detected');
    const background = document.querySelector('.background');
    const moveX = (e.clientX / window.innerWidth) * 80 - 40;
    const moveY = (e.clientY / window.innerHeight) * 80 - 40;
    console.log(`moveX: ${moveX}, moveY: ${moveY}`);
    background.style.transform = `translate(${moveX}px, ${moveY}px)`;
    });
</script>
