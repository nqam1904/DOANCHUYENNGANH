﻿$(document).ready(function(){
    $(".signup-form").hide();
    $(".signup").css("background","none");

    $(".signup").click(function () {
        $(".signup-form").show();
        $(".login-form").hide();
        $(".signup").css("background", "#fff");
        $(".login").css("background", "none");
    });

    $(".login").click(function () {
        $(".signup-form").hide();
        $(".login-form").show();
        $(".signup").css("background", "none");
        $(".login").css("background", "#fff");
    });

});
