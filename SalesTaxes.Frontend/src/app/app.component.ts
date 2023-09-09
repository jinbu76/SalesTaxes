import {Component, inject} from '@angular/core';
import {GlobalService} from "./global.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  globalService: GlobalService = inject(GlobalService);

}
