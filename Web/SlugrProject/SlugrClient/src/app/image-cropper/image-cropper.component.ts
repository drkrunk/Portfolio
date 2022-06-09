import { Component, DoCheck, ElementRef, Input, OnChanges, OnInit, ViewChild } from '@angular/core';
import Cropper from 'cropperjs';
import ViewMode from 'cropperjs'



@Component({
  selector: 'app-image-cropper',
  templateUrl: './image-cropper.component.html',
  styleUrls: ['./image-cropper.component.scss']
})
export class ImageCropperComponent implements OnInit {

  @ViewChild("image", { static: true })
  public imageElement: ElementRef;

  @Input("src")
  public imageSource: string;

  public imageDestination: string;
  private cropper: Cropper;


  config = {

    scalable: false,
    aspectRatio: 1,
    cropBoxResizable: false,
    minCropBoxHeight: 512,
    minCropBoxWidth: 512,
    guides: false,
    rotatable: false,
    responsive: true,
    center: false,
    viewMode: 3,


    crop: () => {
      const canvas = this.cropper.getCroppedCanvas();

    }
  }

  public constructor() {
    this.imageDestination = "";

  }


  private onImageLoad(event) {

    this.cropper.destroy()
    this.cropper = new Cropper(this.imageElement.nativeElement, {

      scalable: false,
      aspectRatio: 1,
      cropBoxResizable: false,
      minCropBoxHeight: 512,
      minCropBoxWidth: 512,
      guides: false,
      rotatable: false,
      responsive: true,
      center: false,
      viewMode: 3,


      crop: () => {
        const canvas = this.cropper.getCroppedCanvas();

      }
    });
  }

  public getCroppedImage() {
    const canvas = this.cropper.getCroppedCanvas();

    return canvas.toDataURL("image/png")

  }

  public ngAfterViewInit() {

    if (!this.imageElement) return


    //this.cropper = new Cropper(this.imageElement.nativeElement, this.config);
    this.cropper = new Cropper(this.imageElement.nativeElement, {

      scalable: false,
      aspectRatio: 1,
      cropBoxResizable: false,
      minCropBoxHeight: 512,
      minCropBoxWidth: 512,
      guides: false,
      rotatable: false,
      responsive: true,
      center: false,
      viewMode: 3,


      crop: () => {
        const canvas = this.cropper.getCroppedCanvas();

      }
    });

    /*
     this.cropper = new Cropper(this.imageElement.nativeElement, {
       scalable: false,
       aspectRatio: 1,
       cropBoxResizable: false,
       minCropBoxHeight: 512,
       minCropBoxWidth: 512,
       guides:false,
       rotatable:false,
       responsive:true,
       center:false,
       viewMode:3,
 
       crop: () => {
         const canvas = this.cropper.getCroppedCanvas();
         this.imageDestination = canvas.toDataURL("image/png");
       }
     });
   */


  }



  public ngOnInit() { }

}
