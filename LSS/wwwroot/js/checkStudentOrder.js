$(window).load(function () {
    $("#flexiselDemo1").flexisel({
        visibleItems: 1,
        animationSpeed: 1000,
        autoPlay: false,
        autoPlaySpeed: 3000,
        pauseOnHover: true,
        enableResponsiveBreakpoints: true,
        responsiveBreakpoints: {
            portrait: {
                changePoint: 480,
                visibleItems: 1
            },
            landscape: {
                changePoint: 640,
                visibleItems: 1
            },
            tablet: {
                changePoint: 768,
                visibleItems: 1
            }
        }
    });
});

$(document).ready(function () {
    $().UItoTop({
        easingType: 'easeOutQuart'
    });
});

$(window).scroll(function () {
    $("#top").show();
    if ($(window).scrollTop() <= 100) {
        $("#top").hide();
    }
});
$("#top").click(function () {
    $(window).scrollTop(100);
    $(this).hide();
});

window.onload = function () {
    var oDiv = document.getElementById('leftSidebar');
    var divT = oDiv.offsetTop;
    var divFooter = document.getElementsByClassName("mkl_footer");
    //console.log(divT);
    window.onscroll = function () {
        // 获取当前页面的滚动条纵坐标位置 （依次为火狐谷歌、safari、IE678）
        var scrollT = document.documentElement.scrollTop || window.pageYOffset || document.body.scrollTop;
        if (scrollT >= divT) {
            if (window.navigator.userAgent.indexOf('MSIE 6.0') != -1) {
                // 兼容IE6代码
                oDiv.style.position = 'absolute';
                oDiv.style.top = scrollT + 'px';
            } else {
                oDiv.style.position = 'fixed';
            }
        } else 
            oDiv.style.position = '';
    }
}

addEventListener("load", function () {
    setTimeout(hideURLbar, 0);
}, false);

function hideURLbar() {
    window.scrollTo(0, 1);
}

