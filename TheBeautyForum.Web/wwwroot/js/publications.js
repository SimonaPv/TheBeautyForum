function likeButton(postId, isPostLiked) {
    let token = document.querySelector("input[name='__RequestVerificationToken']").value;
    let likesCount = document.getElementById(`like-${postId}`);
    let likesIcon = document.getElementById(`like-icon-${postId}`);

    let data = new FormData();
    data.append('postId', postId);

    $.ajax({
        type: "POST",
        url: `/Like/HandleLike`,
        data: data,
        headers: {
            "RequestVerificationToken": token

        },
        processData: false,
        contentType: false,
        success: async function (data) {
            if (!isPostLiked) {
                likesCount.textContent = parseInt(likesCount.textContent) + 1;
                likesIcon.classList.remove("notLikedPost");
                likesIcon.classList.add("likedPost");
            }
            else {
                likesCount.textContent = parseInt(likesCount.textContent) - 1;
                likesIcon.classList.remove("likedPost");
                likesIcon.classList.add("notLikedPost");
            }
        },
        error: function (error) {
            console.error(error.statusCode);
            console.error('Error occurred while uploading object');
        }
    });
}

function myFunction() {
    var input, filter, ul, li, a, i, txtValue;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    ul = document.getElementById("myUL");
    li = ul.getElementsByTagName("li");
    for (i = 0; i < li.length; i++) {
        a = li[i].getElementsByTagName("a")[0];
        txtValue = a.textContent || a.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            li[i].style.display = "";
        } else {
            li[i].style.display = "none";
        }
    }
}