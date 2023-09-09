import { Component, inject } from '@angular/core';
import { ProductService } from './product.service';
import { Observable } from 'rxjs';
import { Product } from '../models/product';
import {GlobalService} from "../global.service";

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss'],
})
export class ProductComponent {
  #productService: ProductService = inject(ProductService);
  #globalService: GlobalService = inject(GlobalService);

  products$: Observable<Product[]> = this.#productService.products$;

  addToCart(product: Product): void {
    this.#globalService.cartCount.update((count: number) => count += 1);
    this.#globalService.cartItems.update(() => [...this.#globalService.cartItems(), product]);
  }
}
