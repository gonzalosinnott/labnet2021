import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { OrderService } from '../order.service';
import { Order } from '../order';
import { MatSnackBar, MatSnackBarHorizontalPosition, MatSnackBarVerticalPosition } from '@angular/material/snack-bar';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource, } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { SelectionModel } from '@angular/cdk/collections';

interface Shippers {
  ShipperId: number;
  CompanyName: string;
  Phone: string;
}

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.scss']
})
export class OrderComponent implements OnInit {
  Id = '';
  ShippedDate!: Date;
  ShipVia = '';
  ShipName = '';
  Address = '';
  City = '';
  Country = '';
  dataSaved = false;
  orderForm: any;
  allOrders!: Observable<Order[]>;
  dataSource!: MatTableDataSource<Order>;
  selection = new SelectionModel<Order>(true, []);
  orderIdUpdate = 0;
  message = null;
  allShippers!: Observable<Shippers[]>;
  ShipperId = '';
  SelectedDate = null;
  horizontalPosition: MatSnackBarHorizontalPosition = 'center';
  verticalPosition: MatSnackBarVerticalPosition = 'bottom';
  displayedColumns: string[] = ['ID', 'ShippedDate', 'ShipVia', 'ShipName', 'Address', 'City', 'Country'];
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private formbulider: FormBuilder, private orderService: OrderService, private _snackBar: MatSnackBar, public dialog: MatDialog) {
    this.orderService.getAllOrders().subscribe(data => {
      this.dataSource = new MatTableDataSource(data);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });
  }

  ngOnInit() {
    this.orderForm = this.formbulider.group({
      ID: ['', [Validators.required]],
      ShippedDate: ['', [Validators.required]],
      ShipVia: ['', [Validators.required]],
      ShipName: ['', [Validators.required]],
      Address: ['', [Validators.required]],
      City: ['', [Validators.required]],
      Country: ['', [Validators.required]]
    });
    this.FillShippersDDL();
    this.LoadAllOrders();
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }
  
  LoadAllOrders() {
    this.orderService.getAllOrders().subscribe(data => {
      this.dataSource = new MatTableDataSource(data);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });
  }

  onFormSubmit() {
    this.dataSaved = false;
    const order = this.orderForm.value;
    this.CreateOrder(order);
    this.orderForm.reset();
  }

  EditOrder(id: number) {
    this.orderService.getOrderById(id).subscribe(order => {
      this.message = null;
      this.dataSaved = false;
      this.orderIdUpdate = order.Id;
      this.orderForm.controls['ShippedDate'].setValue(order.ShippedDate);
      this.orderForm.controls['ShipVia'].setValue(order.ShipVia);
      this.orderForm.controls['ShipName'].setValue(order.ShipName);
      this.orderForm.controls['Address'].setValue(order.Address);
      this.orderForm.controls['City'].setValue(order.City);
      this.orderForm.controls['Country'].setValue(order.Country);
      this.ShipperId = order.ShipVia;
    });
  }

  CreateOrder(order: Order) {
    if (this.orderIdUpdate == 0) {
      order.ShippedDate = this.ShippedDate;
      order.ShipVia = this.ShipVia;
      order.ShipName = this.ShipName;
      order.Address = this.Address;
      order.City = this.City;
      order.Country = this.Country;


      this.orderService.createOrder(order).subscribe(
        () => {
          this.dataSaved = true;
          this.SavedSuccessful(1);
          this.LoadAllOrders();
          this.orderIdUpdate = 0;
          this.orderForm.reset();
        }
      );
    } else {
      order.Id = this.orderIdUpdate;
      order.ShippedDate = this.ShippedDate;
      order.ShipVia = this.ShipVia;
      order.ShipName = this.ShipName;
      order.Address = this.Address;
      order.City = this.City;
      order.Country = this.Country;

      this.orderService.updateOrder(order).subscribe(() => {
        this.dataSaved = true;
        this.SavedSuccessful(0);
        this.LoadAllOrders();
        this.orderIdUpdate = 0;
        this.orderForm.reset();
      });
    }
  }

  DeleteOrder(Id: number) {
    if (confirm("Are you sure you want to delete this ?")) {
      this.orderService.deleteOrderById(Id).subscribe(() => {
        this.dataSaved = true;
        this.SavedSuccessful(2);
        this.LoadAllOrders();
        this.orderIdUpdate = 0;
        this.orderForm.reset();
      });
    }
  }

  FillShippersDDL() {
    this.allShippers = this.orderService.getShippers();
  }  

  resetForm() {
    this.orderForm.reset();
    this.message = null;
    this.dataSaved = false;
    this.LoadAllOrders();
  }

  SavedSuccessful(isUpdate: number) {
    if (isUpdate == 0) {
      this._snackBar.open('Record Updated Successfully!', 'Close', {
        duration: 2000,
        horizontalPosition: this.horizontalPosition,
        verticalPosition: this.verticalPosition,
      });
    }
    else if (isUpdate == 1) {
      this._snackBar.open('Record Saved Successfully!', 'Close', {
        duration: 2000,
        horizontalPosition: this.horizontalPosition,
        verticalPosition: this.verticalPosition,
      });
    }
    else if (isUpdate == 2) {
      this._snackBar.open('Record Deleted Successfully!', 'Close', {
        duration: 2000,
        horizontalPosition: this.horizontalPosition,
        verticalPosition: this.verticalPosition,
      });
    }
  }
}
