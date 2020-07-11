var USER_NAME = localStorage.getItem('userName');
var TOKEN = localStorage.getItem('token');
$.ajaxSetup({
    headers: { 'Authorization': `Bearer ${TOKEN}` }
});


$(document).ready(function () {
    VueBindUserInfo();
    $('#logOutBt').click(LogOut);
})

function VueBindUserInfo() {
    new Vue(
        {
            el: '#navBarBlock',
            data: {
                userName: USER_NAME
            }
        }
    )
}

function LogOut() {
    CleanLocalStorage();
    alert('Logged out');
    location.href = './';
}

function CleanLocalStorage() {
    localStorage.removeItem('token');
    localStorage.removeItem('userName');
}