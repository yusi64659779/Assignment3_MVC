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
    Public Class ApricotsController
        Inherits System.Web.Mvc.Controller

        Private db As New Agriculture_DatabaseEntities

        ' GET: Apricots
        Function Index() As ActionResult
            Dim apricots = db.Apricots.Include(Function(a) a.Fruit)
            Return View(apricots.ToList())
        End Function

        ' GET: Apricots/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim apricot As Apricot = db.Apricots.Find(id)
            If IsNothing(apricot) Then
                Return HttpNotFound()
            End If
            Return View(apricot)
        End Function

        ' GET: Apricots/Create
        Function Create() As ActionResult
            ViewBag.Fruit_ID = New SelectList(db.Fruits, "Fruit_ID", "Fruit_Name")
            Return View()
        End Function

        ' POST: Apricots/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Form_ID,Fruit_ID,Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_Factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_Cup_Dollars")> ByVal apricot As Apricot) As ActionResult
            If ModelState.IsValid Then
                db.Apricots.Add(apricot)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Fruit_ID = New SelectList(db.Fruits, "Fruit_ID", "Fruit_Name", apricot.Fruit_ID)
            Return View(apricot)
        End Function

        ' GET: Apricots/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim apricot As Apricot = db.Apricots.Find(id)
            If IsNothing(apricot) Then
                Return HttpNotFound()
            End If
            ViewBag.Fruit_ID = New SelectList(db.Fruits, "Fruit_ID", "Fruit_Name", apricot.Fruit_ID)
            Return View(apricot)
        End Function

        ' POST: Apricots/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Form_ID,Fruit_ID,Form,Average_Retail_Price_Dollars,Price_Unit,Preparation_yield_Factor,Size_Cup_Equivalent,Size_Unit,Average_Price_Per_Cup_Dollars")> ByVal apricot As Apricot) As ActionResult
            If ModelState.IsValid Then
                db.Entry(apricot).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Fruit_ID = New SelectList(db.Fruits, "Fruit_ID", "Fruit_Name", apricot.Fruit_ID)
            Return View(apricot)
        End Function

        ' GET: Apricots/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim apricot As Apricot = db.Apricots.Find(id)
            If IsNothing(apricot) Then
                Return HttpNotFound()
            End If
            Return View(apricot)
        End Function

        ' POST: Apricots/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim apricot As Apricot = db.Apricots.Find(id)
            db.Apricots.Remove(apricot)
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
