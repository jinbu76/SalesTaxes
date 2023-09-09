import { Component, inject } from '@angular/core';
import { ProductService } from './product.service';
import { Observable } from 'rxjs';
import { Product } from '../models/product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss'],
})
export class ProductComponent {
  private _productService: ProductService = inject(ProductService);
  products$: Observable<Product[]> = this._productService.products$;

}
