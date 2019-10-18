@ModelType Assignment3_MVC.Assignment3_MVC.Fruit
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Fruit</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Fruit_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fruit_Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Agri_Products.Product_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Agri_Products.Product_Name)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
