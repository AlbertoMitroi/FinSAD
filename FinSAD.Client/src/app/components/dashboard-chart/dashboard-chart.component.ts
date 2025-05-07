import {
  Component,
  AfterViewInit,
  ElementRef,
  ViewChild
} from '@angular/core';
import { Chart } from 'chart.js/auto';
import { ChartService } from '../../services/chart.service';

@Component({
  selector: 'app-dashboard-chart',
  templateUrl: './dashboard-chart.component.html',
  styleUrls: ['./dashboard-chart.component.css']
})
export class DashboardChartComponent implements AfterViewInit {
  @ViewChild('chartCanvas') chartRef!: ElementRef<HTMLCanvasElement>;

  constructor(private ChartService: ChartService) {}

  ngAfterViewInit(): void {
    const ctx = this.chartRef.nativeElement.getContext('2d');
    if (!ctx) return;

    const chart = new Chart(ctx, {
      type: 'line',
      data: {
        labels: this.ChartService.getLabels(),
        datasets: this.ChartService.getDatasets()
      },
      options: {
        responsive: true
      }
    });
  }
}
