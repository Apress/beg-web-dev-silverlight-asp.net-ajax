   M S B A M L   `   `   `  ����  BlendProject1     BlendProject1.GetAddresses   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6x,http://schemas.microsoft.com/winfx/2006/xaml   5      <d2http://schemas.microsoft.com/expression/blend/2006   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   6X     �Language$  en-US�-   5         �Name$ Window��5       � Title$ Window��5      $	��640��5      $	��480��6    � 	Resources 5
       � Source   	Addresses  AddressTemplate1 �� Mode �� XPath  OnClick1 g� 	BeginTime �� 
TargetName	 �� TargetProperty
 O� KeyTime O� Value��%6  &	        &	 v     &	 H    � 5      $] WC:\Users\Laurence\Desktop\WebNextBook\Part02\Chapter08\BlendProject1\addressexample.xml?�6*   6�   �� 5      .R�5      �� .+�5      �� ��6   �� $ OneWay=�$ AddressLine1���� 5      ��6   �� $ OneWay=�$ 
PostalCode���� 5      $�� ��6   $��8��6   5      5      �� 5      .��5      U� $ 00:00:00X�6#   $ listBox��68   $U	 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6X   .\�5      �� $
 00:00:00��6   $
 -302Q�6.   �� 5      $
 00:00:03��6   $ 3Q�6.   5      U� 5      $ 00:00:00X�6#   $ listBox��68   $U	 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6X   .\�5      �� $
 00:00:00��6   $ 9Q�6.   �� 5      $
 00:00:03��6   $ 10Q�6.   5      U� 5      $ 00:00:00X�6#   $ listBox��68   $	 (UIElement.Opacity)�6X   .\�5      �� $
 00:00:00��6   $ 0Q�6.   �� 5      $
 00:00:03��6   $ 1Q�6.   5      5       5!      .��5%      � -   5         �Name$ 
LayoutRoot��5%       � DataContext 6   �� $ Default=� �� Source# [  $ /DocumentElement/Address��.+�5&      �� -   5         ��Name$
 tZIP��5&      $
��Left=�6   $��	23,18,0,0q�65   $	��Top=�6H   $	��156��6`   $��23��6l   $��TextBox��6x    �� TextWrapping$
 Wrap=�6�   �� 5'      -   5         ��Name$ button��5'   �   $
��Left=�6    $��
200,18,0,0q�6;   $	��Top=�6O   $��67��6g   $��23��6r   $��Button��6~   6�   �� 5(      -   5         ��Name$ listBox��5(     $
��Left=�6   $��	23,45,0,0q�6'   $	��Top=�6:   $	��244��6R   $	��149��6^   #���  6k   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6�   �� $ OneWay=�5)      �� 5*      $��267,0,230,105q�6
   $��Bottom=�6!   $��45��6<   $��Label��6H   5+      5,      