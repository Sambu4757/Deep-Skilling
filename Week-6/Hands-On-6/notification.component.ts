import { Component } from '@angular/core';
import { NotificationService } from '../../services/notification.service';

@Component({
  selector: 'app-notification',
  standalone: true,
  providers: [NotificationService],
  templateUrl: './notification.component.html'
})
export class NotificationComponent {

  constructor(public notificationService: NotificationService) {}

}
