//打开字滑入效果
window.onload = function () {
	$(".connect p").eq(0).animate({ "left": "0%" }, 600);
	$(".connect p").eq(1).animate({ "left": "0%" }, 400);
};
$(document).ready(function(){
	var $tab_li=$(".tab ul li");
	$tab_li.hover(function(){
		$(this).addClass('selected').siblings().removeClass('selected');
	var index=$tab_li.index(this);
	$("div.tab_box > div").eq(index).show().siblings().hide();
	});
});
//jquery.validate表单验证
$(document).ready(function () {
	//登陆表单验证
	$("#loginForm1").validate({
		rules: {
			username: {
				required: true,//必填
				minlength: 3, //最少6个字符
				maxlength: 32,//最多20个字符
			},
			password: {
				required: true,
				minlength: 6,
				maxlength: 32,
			},
		},
		//错误信息提示
		messages: {
			username: {
				required: "必须填写用户名",
				minlength: "用户名至少为3个字符",
				maxlength: "用户名至多为32个字符",
				remote: "用户名已存在",
			},
			password: {
				required: "必须填写密码",
				minlength: "密码至少为3个字符",
				maxlength: "密码至多为32个字符",
			},
		},
	});
	$("#loginForm2").validate({
		rules: {
			username: {
				required: true,//必填
				minlength: 3, //最少6个字符
				maxlength: 32,//最多20个字符
			},
			password: {
				required: true,
				minlength: 6,
				maxlength: 32,
			},
		},
		//错误信息提示
		messages: {
			username: {
				required: "必须填写用户名",
				minlength: "用户名至少为3个字符",
				maxlength: "用户名至多为32个字符",
				remote: "用户名已存在",
			},
			password: {
				required: "必须填写密码",
				minlength: "密码至少为3个字符",
				maxlength: "密码至多为32个字符",
			},
		},
	});
});

