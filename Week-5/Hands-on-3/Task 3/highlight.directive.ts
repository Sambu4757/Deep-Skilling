import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appHighlight]',
  standalone: true
})
export class HighlightDirective {

  @Input() appHighlight: string = 'yellow';

  constructor(private element: ElementRef) {}

  @HostListener('mouseenter')
  onMouseEnter(): void {
    this.element.nativeElement.style.backgroundColor = this.appHighlight;
  }

  @HostListener('mouseleave')
  onMouseLeave(): void {
    this.element.nativeElement.style.backgroundColor = '';
  }

}