function InsertCommentAjax(text, goodId, node) {
    $.ajax({
        type: 'POST',
        url: '/Good/AddComment',
        data: { text: text, goodId: goodId },
        success: function (data) {
            console.log(data);
            $(node).children(".col-sm-10").children(".panel").children(".panel-heading").attr("comment-id", data);
        }
    });
}



function UpdateComment(node) {
    $(node).closest(".panel").children(".panel-heading").children(".text-right").children(".glyphicon-pencil").hide();
    var prev_text = $(node).closest(".panel").children(".panel-body").html();

    prev_text = prev_text.trim().toString();

    $(node).closest(".panel").children(".panel-body").html("");

    var textarea = $('<textarea class="form-control textcomment updatetext" id="updateCommentArea" rows="5" style="max-width:1250px;" required maxlength="255">' + prev_text + '</textarea><br />');

    var button = $('<a class="btn btn-success btn-submit btn-xs"><span class="glyphicon glyphicon-send"></span> Update</a>');
    $(button).click(function () {
        UpdateCommentAjax(this);
    });
    var cancel_button = $('<a class="btn btn-success btn-danger btn-xs"><span class="glyphicon glyphicon-remove"></span> Cancel</a>');
    $(cancel_button).click(function () {
        CancelUpdate(this, prev_text);
    });
    $(node).closest(".panel").children(".panel-body").append(textarea);
    $(node).closest(".panel").children(".panel-body").append(button);
    $(node).closest(".panel").children(".panel-body").append(cancel_button);
}

function CancelUpdate(node, prev_text) {
    $(node).closest(".panel").children(".panel-heading").children(".text-right").children(".glyphicon-pencil").show();
    $(node).closest(".panel").children(".panel-body").html(prev_text);
}

function UpdateCommentAjax(node) {
    $(node).closest(".panel").children(".panel-heading").children(".text-right").children(".glyphicon-pencil").show();
    var new_text = $(node).siblings("textarea").val();

    var commentId = $(node).closest(".panel").children(".panel-heading").attr("comment-id");

    $.ajax({
        type: 'POST',
        url: '/Good/UpdateComment',
        data: { text: new_text, commentId: commentId },
        success: function (data) {
        }
    });

    $(node).closest(".panel").children(".panel-body").html(new_text);
}

function DeleteComment(node) {
    var commentId = $(node).closest(".panel").children(".panel-heading").attr("comment-id");
    $("#CommentToDeleteid").val(commentId);
}

function DeleteCommentAjax() {
    var commentId = $("#CommentToDeleteid").val();
    console.log(commentId);
    $("#ModalDelete").modal("hide");
    $("div[comment-id='" + commentId + "']").closest(".comment").remove();
    console.log($("div[comment-id=" + commentId + "]"));
    $.ajax({
        type: 'POST',
        url: '/Good/DeleteComment',
        data: { commentId: commentId },
        success: function (data) {

        }
    });
}