@ModelType Assignment3_MVC.Assignment3_MVC.Vegetable
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Vegetable</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Veg_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Veg_Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Agri_Products.Product_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Agri_Products.Product_Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Veg_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
