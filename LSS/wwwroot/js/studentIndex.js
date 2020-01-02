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

if ($('#selectResult').children().length <= 100) {
    $("#selectResult").css({
        "height": "500px"
    });
}
var startTime = 0; //开始时间
var endtime = 0; //结束时间
var date = 0; //日期
var place = "南山图书馆"; //图书馆
var floor = "1楼"; //楼层
function getIdOfButton(id) {
    //获取点击按钮的id
    //alert(id);
    //获取筛选结果
    if (startTime == 0 || endtime == 0) {
        alert("请选择时间后预定！");
    } else {
        //调用函数，将开始时间，结束时间，日期，图书馆，楼层发送给后端
    }
}

//发送函数
function sendData(startTime,endTime,date,place,floor){

}

//将获取到的数据设置为HTML
function generateHTML(re){

}
//初始化图书馆和楼层
window.onload = function () {
    document.getElementById("today").innerHTML = GetDateStr(0);
    document.getElementById("tomorrow").innerHTML = GetDateStr(1);
    var close = "<span class='close'>&times;</span>";
    $("#result1").text("");
    $("#result1").append(close + place);
    $("#result2").text("");
    $("#result2").append(close + floor);

}
$(document).ready(function () {
    var close = "<span class='close'>&times;</span>";
    $("#result1").text("");
    $("#result1").append(close + place);
    $("#result2").text("");
    $("#result2").append(close + floor);
});
$(".panel-body .time .label.label-success").click(function () {

    var val = $(this).html();
    startTime = parseInt(val.split("：")[0]); //获取到开始时间
    //console.log(startTime);
    var endTime = $(".endTime");
    for (var i = 0; i < endTime.length; i++) {
        var value = endTime[i].innerText;
        var tmp = parseInt(value.split("：")[0]);
        if (tmp > startTime) {
            endTime[i].style.display = "block";
        } else {
            endTime[i].style.display = "none";
        }
    }
});
$(".panel-body .endTime .label.label-success").click(function () {
    var val = $(this).html();
    endtime = parseInt(val.split("：")[0]);

    console.log(startTime);
});

$(document).ready(function () {
    $(".close").click(function () {
        $(this).parent().hide();
    });
})



$(".modal-footer .btn.btn-primary").click(function () {
    if (startTime === 0 || endtime === 0) {
        alert("请选择时间！");
    } else {
        var st = startTime + ":00"; //开始时间
        var et = endtime + ":00"; //结束时间
        var day;
        var close = "<span class='close'>&times;</span>";
        if (date == 0) {
            day = GetDateStr(0);
        } else {
            day = GetDateStr(1);
        }
        $("#result3").text("");
        $("#result3").append(close + st);
        $("#result4").text("");
        $("#result4").append(close + et);
        $("#result5").text("");
        $("#result5").append(close + day);

        // $("#result3")=close+st;
        // $("#result4").innerHTML=close+et;
        // $("#result5").innerHTML=close+day;
        $('#myStartTime').modal('hide');
    }
});

function GetDateStr(AddDayCount) {
    var dd = new Date();
    dd.setDate(dd.getDate() + AddDayCount); //获取AddDayCount天后的日期
    var y = dd.getFullYear();
    var m = dd.getMonth() + 1; //获取当前月份的日期
    var d = dd.getDate();
    return y + "-" + m + "-" + d;
}



$(".date .label.label-success").click(function () {
    var val = $(this).html();
    if (val[0] == "今") {
        date = 0;
    } else {
        date = 1;
    }
    console.log(date);
});

function getValueOfPlace() { //获取图书馆选择
    var options = $("#selectPlace option:selected"); //获取选中的项
    place = options.text();
    var close = "<span class='close'>&times;</span>";
    $("#result1").text("");
    $("#result1").append(close + place);
}

function getValueOfFloor() { //获取楼层选择
    var options = $("#selectFloor option:selected"); //获取选中的项
    floor = options.text();
    var close = "<span class='close'>&times;</span>";
    $("#result2").text("");
    $("#result2").append(close + floor);
}
//监听结果栏，当发生变化时，发送数据给后端
$("#panel-body-result").bind('DOMNodeInserted', function (e) {
    //开始时间，结束时间，地点，楼层，以及日期
});



