   M S B A M L   `   `   `  ����D  @Phonebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Phonebook.ViewPhonebook.View  5      9!clr-namespace:Phonebook.ViewModelPhonebook.ViewModel  5      $    Phonebook.View.EditContactView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Phonebook.View     5      7	viewmodel!clr-namespace:Phonebook.ViewModel     5        N� Title$  Edit Contact��5       � DataContext 5	      ��  �� RelativeSource �� *Self+.��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Name:��6-   �� 5   
   $��0��6   $��1��6   ��6/   �� *Name+�� 5   
   $��1��6   $��0��6   $��Phone Number:��6-   �� 5   
   $��1��6   $��1��6   ��6/   �� *PhoneNumber+�� 5   
   $��2��6   $
��Save��6   $��20��6-   $��1��6Y   $��Right=�6i   $	��Top=�6�   ��69   �� *SaveCommand+6�   5      5      