# Thread로 폼 속성 및 이벤트 호출

[메인 폼]

 LoadingForm loading = new LoadingForm(this);
 loading.function = (()
     =>
 {
     exeConfig._Connect();
 });
 loading.Message = (()
     =>
 {
     exeConfig._ErrorMessage();
 });
 loading.ShowDialog();
 _CloseProcess();
}


[자식 폼]

 private void LoadingForm_Shown(object sender, EventArgs e)
 {
     Thread thread = new Thread(
         () =>
         {
             Login?.Invoke();
             this.Invoke((Action)(() => //Action -> 대리자로써 form 이벤트 호출
             {
             this.Close();
             Message?.Invoke();
             }));
         });
     thread.Start();
 }
        


참조 : https://rightnowdo.tistory.com/entry/WinForm-UI-Freeze-%ED%95%B4%EA%B2%B0-%ED%95%B4%EC%A3%BC%EB%8A%94-%EB%B9%84%EB%8F%99%EA%B8%B0-%ED%98%B8%EC%B6%9C
