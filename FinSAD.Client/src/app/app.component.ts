import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { LogService } from './services/log.service';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  constructor (private logService: LogService) {}
  title = 'FinSAD';
  ngOnInit() {

  }
}
