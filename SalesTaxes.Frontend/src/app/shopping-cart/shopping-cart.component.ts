import {AfterViewInit, Component, inject} from '@angular/core';
import {GlobalService} from "../global.service";


@Component({
  selector: 'app-shopping-cart',
  templateUrl: './shopping-cart.component.html',
  styleUrls: ['./shopping-cart.component.scss']
})
export class ShoppingCartComponent implements AfterViewInit {

  globalService: GlobalService = inject(GlobalService);
  fullTaxes: string = '';
  total: string = '';


  ngAfterViewInit(): void {
    setTimeout(() => {
      let fullTaxes: number = 0;
      let total: number = 0;
      this.globalService.cartItems().forEach(product => {

        let tax: number = product.Price * product.Taxes / 100;
        if (product.IsImported)
          tax += product.Price * product.DutyFree / 100;

        tax = this.nearest0point5(tax);

        fullTaxes += tax;
        this.fullTaxes = fullTaxes.toFixed(2);
        const fullPrice: number = product.Price + tax;
        product.FullPrice = (fullPrice).toFixed(2);
        total += fullPrice;
        this.total = total.toFixed(2);
      })
    }, 500);
  }

  private nearest0point5(tax: number): number {
    let taxString = tax.toFixed(2);
    const lastNumber: number = +taxString[taxString.length - 1];
    if (lastNumber === 0 || lastNumber === 5) return tax;
    if (lastNumber < 5) return +taxString + ((5 - lastNumber)/100);
    return +taxString  + ((10 - lastNumber)/100);
  }
}
