   M S B A M L   `   `   `  ����J  FProductPractic2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProductPractic2ProductPractic2  5           ProductPractic2.WorkInfoEF   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ProductPractic2     5        N� Title$  
WorkInfoEF��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   �� -   5         ��Name$ Position��5      $��1��6$   �� 5   
   -   5        $ 	DateStart��5      $��2��6&   �� 5   
   -   5        $ Salary��5      $��3��6#   �� 5   
   -   5         ��Name$	 Add��5      $��4��6   $��Добавление��6+   $��Center=�6@   6[   �� 5   
   -   5        $ Delete��5      $��5��6!   $��Удаление��6.   $��Center=�6A   6\   �� 5   
   -   5        $ Update��5      $��6��6!   $��Обновление��6.   $��Center=�6D   6_   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ WorkInfoTable��5   F      AutoGenerateColumns .     CanUserAddRows .  $��0��6]      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%   	   
Visibility$	 	Collapsed=�64   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6K   �� *ID_WorkInfo+  5      $ Должность��6%   
 68   �� *
WorkPost+  5      $( "Дата начала работы��6%   
 6A   �� *DateStartOfWork+  5       $ Зарплата��6%   
 67   �� *Salary+5"      5#      5$      