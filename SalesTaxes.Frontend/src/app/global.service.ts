import {Injectable, signal, WritableSignal} from '@angular/core';
import {Product} from "./models/product";

@Injectable({
  providedIn: 'root'
})
export class GlobalService {

  cartCount: WritableSignal<number> = signal(0);
  cartItems: WritableSignal<Product[]> = signal([]);

}
