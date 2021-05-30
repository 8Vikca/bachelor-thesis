export interface UpdateUser {     //model na update uzivatela
  name?: string;
  surname?: string;
  email?:string;
  currentPassword?:string;
  newPassword?:string;
}
