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
    Public Class FruitsController
        Inherits System.Web.Mvc.Controller

        Private db As New Agriculture_DatabaseEntities

        ' GET: Fruits
        Function Index() As ActionResult
            Dim fruits = db.Fruits.Include(Function(f) f.Agri_Products)
            Return View(fruits.ToList())
        End Function

        ' GET: Fruits/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim fruit As Fruit = db.Fruits.Find(id)
            If IsNothing(fruit) Then
                Return HttpNotFound()
            End If
            Return View(fruit)
        End Function

        ' GET: Fruits/Create
        Function Create() As ActionResult
            ViewBag.Product_ID = New SelectList(db.Agri_Products, "Product_ID", "Product_Name")
            Return View()
        End Function

        ' POST: Fruits/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Fruit_ID,Product_ID,Fruit_Name")> ByVal fruit As Fruit) As ActionResult
            If ModelState.IsValid Then
                db.Fruits.Add(fruit)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Product_ID = New SelectList(db.Agri_Products, "Product_ID", "Product_Name", fruit.Product_ID)
            Return View(fruit)
        End Function

        ' GET: Fruits/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim fruit As Fruit = db.Fruits.Find(id)
            If IsNothing(fruit) Then
                Return HttpNotFound()
            End If
            ViewBag.Product_ID = New SelectList(db.Agri_Products, "Product_ID", "Product_Name", fruit.Product_ID)
            Return View(fruit)
        End Function

        ' POST: Fruits/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Fruit_ID,Product_ID,Fruit_Name")> ByVal fruit As Fruit) As ActionResult
            If ModelState.IsValid Then
                db.Entry(fruit).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Product_ID = New SelectList(db.Agri_Products, "Product_ID", "Product_Name", fruit.Product_ID)
            Return View(fruit)
        End Function

        ' GET: Fruits/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim fruit As Fruit = db.Fruits.Find(id)
            If IsNothing(fruit) Then
                Return HttpNotFound()
            End If
            Return View(fruit)
        End Function

        ' POST: Fruits/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim fruit As Fruit = db.Fruits.Find(id)
            db.Fruits.Remove(fruit)
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
