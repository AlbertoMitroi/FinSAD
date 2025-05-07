import { Injectable } from '@angular/core';
import { ChartDataset } from '../models/ChartDataset';

@Injectable({
  providedIn: 'root'
})
export class ChartService {
  getLabels(): string[] {
    return [
      'January', 'February', 'March', 'April', 'May', 'June',
      'July', 'August', 'September', 'October', 'November', 'December'
    ];
  }

  getDatasets(): ChartDataset[] {
    return [
      {
        label: 'USD',
        data: [3200, 8700, 4300, 10200, 7600, 5400, 9800, 12000, 8900, 4100, 13400, 7700],
        borderColor: 'red',
        borderWidth: 2
      },
      {
        label: 'GBP',
        data: [2800, 4900, 3600, 9100, 7200, 3800, 8600, 9300, 7700, 4500, 10100, 6900],
        borderColor: 'grey',
        borderWidth: 2
      },
      {
        label: 'EUR',
        data: [4000, 7200, 3000, 8500, 9700, 6300, 7800, 9100, 8800, 5500, 9600, 6200],
        borderColor: 'blueviolet',
        borderWidth: 2
      }
    ];
  }
}
