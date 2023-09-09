import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductComponent } from './product/product.component';
import { ShoppingCartComponent } from './shopping-cart/shopping-cart.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'product-list',
    pathMatch: 'full'
  },
  {
    path: 'product-list',
    component: ProductComponent,
  },
  {
    path: 'shopping-cart',
    component: ShoppingCartComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
