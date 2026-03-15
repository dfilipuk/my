import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-drag-and-drop',
  templateUrl: './drag-and-drop.component.html',
  styleUrls: ['./drag-and-drop.component.scss']
})
export class DragAndDropComponent implements OnInit {
  constructor() { }

  @Output() hideOverlay = new EventEmitter();

  @Output() fileDropped = new EventEmitter<Array<File>>();

  ngOnInit() {
  }

  public onDrop(event: DragEvent) {
    event.preventDefault();
    event.stopPropagation();

    const { data } = event;
    let files = [];

    if (data.items) {
      for (let i = 0; i < data.items.length; i++) {
        if (data.items[i].kind === 'file') {
          files.push(data.items[i].getAsFile());
        }
      }
    } else {
      files = Array.from(data.files);
    }

    this.fileDropped.emit(files);
    this.hideOverlay.emit();
  }

  public onDragOver(event: DragEvent) {
    event.preventDefault();
  }

  public onDragLeave(event: DragEvent) {
    this.hideOverlay.emit();
  }
}
