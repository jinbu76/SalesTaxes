import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../models/product';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  private _http: HttpClient = inject(HttpClient);
  products$: Observable<Product[]> = this._http.get<Product[]>(
    environment.productUrl,
  );
}
