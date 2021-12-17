$(document).ready(() => {
    $(".delete-category-button").on("click", function () {
        const row = $(this).closest(".category-row")
        const id = $(row).data("category-id");

        if (Number.isFinite(id)) {
            Swal.fire({
                title: 'Are you sure?',
                text: "You won't be able to revert this!",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!'
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        type: "POST",
                        url: `Category/Delete/${id}`,
                        success: function (res) {
                            $(row).remove();
                            Swal.fire(
                                'Deleted!',
                                'Your file has been deleted.',
                                'success'
                            )
                        }
                    })
                }
            })
        }

    })
})