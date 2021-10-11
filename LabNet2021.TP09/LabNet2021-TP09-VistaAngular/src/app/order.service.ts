import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Order} from './order';
import { Shippers } from './order';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  url = 'http://localhost:65077/Api/Orders';

  constructor(private http: HttpClient) { }

  getAllorders(): Observable<Order[]> {
    return this.http.get<Order[]>(this.url + '/GetAllOrders');
  }

  getOrderById(OrderId: number): Observable<Order> {
    return this.http.get<Order>(this.url + '/GetOrderById/' + OrderId);
  }

  createOrder(order: Order): Observable<Order> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<Order>(this.url + '/InsertOrder/',
    order, httpOptions);
  }

  updateOrder(order: Order): Observable<Order> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };

    return this.http.put<Order>(this.url + '/UpdateOrder/',
    order, httpOptions);
  }

  deleteOrderById(orderId: number): Observable<number> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.delete<number>(this.url + '/DeleteOrder?id=' + orderId,
      httpOptions);
  }

  getShippers(): Observable<Shippers[]> {
    return this.http.get<Shippers[]>(this.url + '/Shippers');
  }
}
