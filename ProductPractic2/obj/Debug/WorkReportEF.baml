   M S B A M L   `   `   `  ����J  FProductPractic2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProductPractic2ProductPractic2  5      "    ProductPractic2.WorkReportEF   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ProductPractic2     5        N� Title$  WorkReportEF��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   �� -   5         ��Name$ IDPeople��5      $��1��6$   �� 5   
   -   5        $ 
IDWorkInfo��5      $��2��6&   �� 5   
   -   5         ��Name$	 Add��5      $��3��6   $��Добавление��6+   $��Center=�6@   6[   �� 5   
   -   5        $ Delete��5      $��4��6!   $��Удаление��6.   $��Center=�6A   6\   �� 5   
   -   5        $ Update��5      $��5��6!   $��Обновление��6.   $��Center=�6C   6^   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ WorkReportTable��5   F      AutoGenerateColumns .     CanUserAddRows .  $��0��6_      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  Идентификатор��6%   	   
Visibility$	 	Collapsed=�6<   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6S   �� *ID_WorkReport+  5      $5 /Идентификатор сотрудника��6%   
 6G   �� *	People_ID+  5      $- 'Идентификатор отчета��6%   
 6C   �� *WorkInfo_ID+5      5       5!      