import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { ProductComponent } from './product.component';
import {MatButtonModule} from "@angular/material/button";

@NgModule({
  declarations: [ProductComponent],
  exports: [ProductComponent],
    imports: [CommonModule, HttpClientModule, MatButtonModule],
})
export class ProductModule {}
