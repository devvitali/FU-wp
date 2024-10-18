<?php
/**
 * The header for our theme
 *
 * This is the template that displays all of the <head> section and everything up until <div id="content">
 *
 * @link https://developer.wordpress.org/themes/basics/template-files/#template-partials
 *
 * @package Founders_Unplugged
 */

?>
<!doctype html>
<html <?php language_attributes(); ?>>

<head>
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <meta charset="<?php bloginfo( 'charset' ); ?>">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="profile" href="https://gmpg.org/xfn/11">
    <link href="https://fonts.googleapis.com/css2?family=Comfortaa:wght@300..700&display=swap" rel="stylesheet">
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@fancyapps/ui@5.0/dist/fancybox/fancybox.css" />
  <link href="https://fonts.googleapis.com/css2?family=Comfortaa&display=swap" rel="stylesheet">
  <link rel="stylesheet" href="<?php echo get_template_directory_uri(); ?>/css/style.css">
  <?php wp_head(); ?>
</head>

<body <?php body_class(); ?>>
<?php wp_body_open(); ?>
  <div class="wrapper">
      <?php 
        $form = get_field('form_shortcode', 'option');
	    $form_step = get_field('form_shortcode_step', 'option');
        $logo = get_field('logo', 'option');
        $button = get_field('form_button', 'option');
      ?>
    <header class="page-header">
      <div class="header-container">
        <div class="header-wrapper">
          <div class="burger-wrapper">
            <div class="burger-box">
              <span></span>
              <span></span>
              <span></span>
            </div>
          </div>
          <div class="logo">
            <?php if($logo): ?>
              <a href="<?php echo esc_url( home_url( '/' ) ); ?>">
                <img src="<?php echo $logo; ?>" alt="logo">
              </a>
            <?php endif; ?>
          </div>
        </div>
        <div class="sliding-panel-content">
          <?php if($logo): ?>
            <a class="logo" href="<?php echo esc_url( home_url( '/' ) ); ?>">
              <img src="<?php echo $logo; ?>" alt="logo">
            </a>
          <?php endif; ?>
          <ul class="menu-list">
			  <?php 
                    if( have_rows('menu_s', 'option') ):
                        while( have_rows('menu_s', 'option') ): the_row();
                           $name_menu_s = get_sub_field('name_menu_s');
                           $section = get_sub_field('section');
               ?>
			         <li><a data-goto=".<?php echo esc_html($section); ?>" href="#"><?php echo $name_menu_s; ?></a></li>
        	   <?php
                    endwhile;
               endif;
               ?>
          </ul>
          <a class="popup-link subscribe-link" href="#steps"><?php echo $button; ?></a>
		  <a class="popup-link steps-popup-link" href="#subscribe">Subscribe to get updates</a>
        </div>
        <div class="sliding-panel-fade-screen"></div>
        
        <div class="popup" id="subscribe">
          <div class="popup-body">
            <div class="popup-content">
              <div class="popup-box">
                <a class="popup-close close-popup" href="#header">
                  <img src="<?php echo get_template_directory_uri(); ?>/img/svg/close-popup.svg" alt="close">
                </a>
                <div class="popup-descr">
                  <img src="<?php echo get_template_directory_uri(); ?>/img/butterflies/butterfly-9.png" alt="butterfly">
                  <h4>Subscribe to get updates</h4>
                  <?php echo do_shortcode($form); ?>
                </div>
              </div>
            </div>
          </div>
        </div>
		  
		<div class="popup" id="steps">
          <div class="popup-body">
            <div class="popup-content">
              <div class="popup-box">
                <a class="popup-close close-popup" href="#header">
                  <img src="<?php echo get_template_directory_uri(); ?>/img/svg/close-popup.svg" alt="close">
                </a>
                <div class="popup-descr">
				  <div id="form-container">
					  <?php echo do_shortcode($form_step); ?>
				  </div>
				  
				  <div class="ty-message" id="success-message" style="display: none;">
					  <div class="divider"></div>
					  <p>
						  Thank you for completing the form! We will be in touch with you shortly
					  </p>
					  <a href="<?php echo esc_url( home_url( '/' ) ); ?>">Back to the home page</a>
				  </div>
                  <img src="<?php echo get_template_directory_uri(); ?>/img/butterflies/butterfly-8.png" alt="butterfly">
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </header>
