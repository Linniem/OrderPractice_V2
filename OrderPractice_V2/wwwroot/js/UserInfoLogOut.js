VueBindUserInfo();

$(document).ready(function () {
    $('#logOutBt').click(LogOut);

    function LogOut() {
        localStorage.removeItem('token');
        localStorage.removeItem('userName');
        alert('Logged out');
        location.href = './';
    }
})

function VueBindUserInfo() {
    var VueUserInfo = new Vue(
        {
            el: '#navBarBlock',
            data: {
                userName: localStorage.getItem('userName')
            }
        }
    )
}