   M S B A M L   `   `   `  ����B  >Diplomm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DiplommDiplomm  5   	       Diplomm.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Diplomm     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ ListView��5
      $
��Left=�6%   $	��365��6@   $��	10,44,0,0q�6M   $	��Top=�6`   $	��312��6x   ��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6!   .+�5      �� $	��150��6%   .+�5      �� ��6(   �� *Title+6A   �� 5      ��6(   �� *Author+6B   �� 5      ��6(   �� *Genre+6A   5      �� 5       ��Name$ delete��6!   -   5        $��Удалить��5   1   6\   �� 5      $ change��6!   -   5        $��Изменить��5   1   6[   5      5      5      �� 5   
   -   5        $!��Добавить книгу��5      $
��Left=�6*   $��480,291,0,0q�6E   $	��Top=�6Z   $��95��6r   $��26��6}   6�   �� 5   
   -   5         ��Name$ Titlebox��5      $
��Left=�6$   $��23��6?   $��
375,63,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��368��6�   �� 5   
   -   5        $ 	AuthorBox��5      $
��Left=�6%   $��23��6@   $��375,132,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��368��6�   6�   �� 5   
   -   5        $ YearBox��5      $
��Left=�6#   $��24��6>   $��375,180,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��368��6�   �� 5   
   -   5        $ GenreBox��5      $
��Left=�6$   $��23��6?   $��375,231,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��368��6�   �� 5   
   $
��Left=�6   $��
375,47,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $	��143��6o   $��16��6{   �� 6�   $!�Название книги��6�   �� 6�   �� 6�   6�   �� 5   
   $
��Left=�6   $��375,110,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��17��6p   $	��121��6|   �� 6�   $�
Автор��6�   �� 6�   �� 6�   6�   �� 5    
   $
��Left=�6   $��375,161,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��16��6p   $	��121��6|   �� 6�   $�Год издания��6�   �� 6�   �� 6�   6�   �� 5!   
   $
��Left=�6   $��375,215,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��16��6p   $	��121��6|   $��Жанр��6�   �� 5"   
   -	   5        $
 Save��5"      $��Сохранить��6   $
��Left=�63   $��375,291,0,0q�6N   $	��Top=�6c   $	��100��6{   $��26��6�   6�   �� 5#   
   -
   5        $ Poisk��5#      $
��Left=�6!   $��23��6<   $��	10,16,0,0q�6H   $
 Wrap=�6[   $	��Top=�6o   $	��338��6�   6�   5%      5&      