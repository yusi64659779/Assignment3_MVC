@ModelType Assignment3_MVC.Assignment3_MVC.Blueberry
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Blueberry</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Form)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Form)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Average_Retail_Price_Dollars)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Average_Retail_Price_Dollars)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Price_Unit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Price_Unit)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Preparation_yield_Factor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Preparation_yield_Factor)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Size_Cup_Equivalent)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Size_Cup_Equivalent)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Size_Unit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Size_Unit)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Average_Price_Per_Cup_Dollars)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Average_Price_Per_Cup_Dollars)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Fruit.Fruit_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fruit.Fruit_Name)
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
