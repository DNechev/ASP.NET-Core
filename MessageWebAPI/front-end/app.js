const appUrl = 'https://localhost:44302/api/';
let currentUser = null;

function createMessages() {

}

function renderMessages(data) {
    for (let message of data) {
        $('#messages')
            .append('<div class="message d-flex justify-content-start"><strong>'
                + message.user
                + '</strong>: '
                + message.content
                + '</div>')

}

function loadMessages() {
    $.get({
        url: appUrl + 'messages/all',
        success: function success(data) {
            renderMessages(data);
        },
        error: function error(error) {
            console.log(error);
        }
    });
}