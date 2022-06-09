import { Component, OnInit, ViewChild } from '@angular/core';
import { ImageCropperComponent } from '../image-cropper/image-cropper.component';
import { AngularFireStorage } from 'angularfire2/storage';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss'],
})
export class ProfileComponent implements OnInit {

  selectedFile: File;
  private url:string | ArrayBuffer ;

  @ViewChild(ImageCropperComponent) imageCropper:ImageCropperComponent;



  constructor(private afStorage: AngularFireStorage) {}

  public ngOnInit(): void {
  }

  onFileChanged(event):void {
    if (event.target.files && event.target.files[0]) {
      var reader = new FileReader();
      reader.readAsDataURL(event.target.files[0]); 
      reader.onload = (event) => { 
        this.url = event.target.result;
      }
    }
  }

  onUpload():void {
    let url:string = this.imageCropper.getCroppedImage();

    let s = url.slice(22, url.length);

    let decodedImage = this.dataURItoBlob(s);

    //now, use the decodedData instead of the base64 one
    var blob = new Blob([decodedImage], {type: 'image/jpg'});

    ///now it should work properly
    var file = new File([blob], 'imageFileName.jpg');

    //this.afStorage.upload('/images/avatars/imageFileName.jpg', file);

    //fetch(url).then(res => this.afStorage.upload('/images/avatars', res.blob()))
    //console.log(blob);

  }

  dataURItoBlob(dataURI) {
    const byteString = window.atob(dataURI);
    const arrayBuffer = new ArrayBuffer(byteString.length);
    const int8Array = new Uint8Array(arrayBuffer);
    for (let i = 0; i < byteString.length; i++) {
      int8Array[i] = byteString.charCodeAt(i);
    }
    const blob = new Blob([int8Array], { type: 'image/png' });    
    return blob;
 }
}
