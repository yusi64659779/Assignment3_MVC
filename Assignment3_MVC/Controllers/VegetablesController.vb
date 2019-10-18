Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Assignment3_MVC.Assignment3_MVC

Namespace Controllers
    Public Class VegetablesController
        Inherits System.Web.Mvc.Controller

        Private db As New Agriculture_DatabaseEntities

        ' GET: Vegetables
        Function Index() As ActionResult
            Dim vegetables = db.Vegetables.Include(Function(v) v.Agri_Products)
            Return View(vegetables.ToList())
        End Function

        ' GET: Vegetables/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vegetable As Vegetable = db.Vegetables.Find(id)
            If IsNothing(vegetable) Then
                Return HttpNotFound()
            End If
            Return View(vegetable)
        End Function

        ' GET: Vegetables/Create
        Function Create() As ActionResult
            ViewBag.Product_ID = New SelectList(db.Agri_Products, "Product_ID", "Product_Name")
            Return View()
        End Function

        ' POST: Vegetables/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Veg_ID,Product_ID,Veg_Name")> ByVal vegetable As Vegetable) As ActionResult
            If ModelState.IsValid Then
                db.Vegetables.Add(vegetable)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Product_ID = New SelectList(db.Agri_Products, "Product_ID", "Product_Name", vegetable.Product_ID)
            Return View(vegetable)
        End Function

        ' GET: Vegetables/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vegetable As Vegetable = db.Vegetables.Find(id)
            If IsNothing(vegetable) Then
                Return HttpNotFound()
            End If
            ViewBag.Product_ID = New SelectList(db.Agri_Products, "Product_ID", "Product_Name", vegetable.Product_ID)
            Return View(vegetable)
        End Function

        ' POST: Vegetables/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Veg_ID,Product_ID,Veg_Name")> ByVal vegetable As Vegetable) As ActionResult
            If ModelState.IsValid Then
                db.Entry(vegetable).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Product_ID = New SelectList(db.Agri_Products, "Product_ID", "Product_Name", vegetable.Product_ID)
            Return View(vegetable)
        End Function

        ' GET: Vegetables/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vegetable As Vegetable = db.Vegetables.Find(id)
            If IsNothing(vegetable) Then
                Return HttpNotFound()
            End If
            Return View(vegetable)
        End Function

        ' POST: Vegetables/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim vegetable As Vegetable = db.Vegetables.Find(id)
            db.Vegetables.Remove(vegetable)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
