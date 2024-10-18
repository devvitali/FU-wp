<?php
/**
 * The template for displaying the footer
 *
 * Contains the closing of the #content div and all content after.
 *
 * @link https://developer.wordpress.org/themes/basics/template-files/#template-partials
 *
 * @package Founders_Unplugged
 */

?>
    <?php 
        $button = get_field('form_button', 'option');
        $title = get_field('title_foo', 'option');
        $descr = get_field('description_foo', 'option');
        $image = get_field('image_foo', 'option');
        $email = get_field('email_foo', 'option');
        $inst = get_field('instagram_foo', 'option');
        $x_tv = get_field('x_foo', 'option');
		$linkdn = get_field('linkedin_foo', 'option');
		$faceboo = get_field('facebook_foo', 'option');
        $copyr = get_field('copyright_foo', 'option');
    ?>
    <footer class="footer">
      <div class="container">
        <div class="footer-wrapper">
          <div class="footer-item">
            <h3><?php echo $title; ?></h3>
            <div class="mobile-img">
              <?php if($image): ?>
                <?php echo wp_get_attachment_image($image['id'], 'full'); ?>
              <?php endif; ?>
            </div>
            <p><?php echo $descr; ?></p>
            <div class="social-media">
              <?php if($inst): ?>
                <a class="instagram-link" href="<?php echo $inst; ?>" target="_blank">
                  <svg width="38" height="38" viewBox="0 0 38 38" fill="none" xmlns="http://www.w3.org/2000/svg">
                    <path
                      d="M28.1667 9.8335H28.1833M10.6667 2.3335H27.3333C31.9357 2.3335 35.6667 6.06446 35.6667 10.6668V27.3335C35.6667 31.9359 31.9357 35.6668 27.3333 35.6668H10.6667C6.0643 35.6668 2.33334 31.9359 2.33334 27.3335V10.6668C2.33334 6.06446 6.0643 2.3335 10.6667 2.3335ZM25.6667 17.9502C25.8724 19.3372 25.6354 20.7539 24.9896 21.9985C24.3438 23.2432 23.3219 24.2525 22.0694 24.883C20.8169 25.5134 19.3974 25.7328 18.013 25.5101C16.6286 25.2873 15.3496 24.6336 14.3581 23.6421C13.3665 22.6506 12.7129 21.3716 12.4901 19.9872C12.2673 18.6028 12.4868 17.1833 13.1172 15.9308C13.7477 14.6783 14.757 13.6564 16.0017 13.0106C17.2463 12.3647 18.6629 12.1278 20.05 12.3335C21.4649 12.5433 22.7748 13.2026 23.7862 14.214C24.7976 15.2254 25.4569 16.5353 25.6667 17.9502Z"
                      stroke="#009951" stroke-width="4" stroke-linecap="round" stroke-linejoin="round" />
                  </svg>
                </a>
              <?php endif; ?>
              <?php if($x_tv): ?>
                <a class="twitter-link" href="<?php echo $x_tv; ?>" target="_blank">
                  <svg width="1200" height="1227" viewBox="0 0 1200 1227" fill="none" xmlns="http://www.w3.org/2000/svg">
					<g clip-path="url(#clip0_1081_148)">
					<g mask="url(#mask0_1081_148)">
					<path d="M714.163 519.284L1160.89 0H1055.03L667.137 450.887L357.328 0H0L468.492 681.821L0 1226.37H105.866L515.491 750.218L842.672 1226.37H1200L714.137 519.284H714.163ZM569.165 687.828L521.697 619.934L144.011 79.6944H306.615L611.412 515.685L658.88 583.579L1055.08 1150.3H892.476L569.165 687.854V687.828Z" fill="#149926"/>
					</g>
					</g>
				  </svg>
                </a>
              <?php endif; ?>
				<?php if($linkdn): ?>
				<a class="linkid-link" href="<?php echo $linkdn; ?>" target="_blank">
                  <svg width="144" height="132" viewBox="0 0 144 132" fill="none" xmlns="http://www.w3.org/2000/svg">
					<path d="M33.125 40H6.25C4.375 40 3.125 41.25 3.125 43.125V128.125C3.125 130 4.375 131.25 6.25 131.25H33.125C35 131.25 36.25 130 36.25 128.125V43.125C36.25 41.25 35 40 33.125 40Z" fill="#149926"/>
					<path d="M106.875 39.375C96.25 39.375 88.125 43.125 83.125 47.5V43.125C83.125 41.25 81.875 40 80 40H50C48.75 40 48.125 40.625 47.5 41.25C46.875 41.875 46.875 42.5 46.875 43.125C46.875 50 46.875 127.5 46.875 128.125C46.875 128.75 47.5 130 47.5 130C48.125 130.625 48.75 130.625 49.375 130.625H79.375C81.25 130.625 82.5 129.375 82.5 127.5V88.125C82.5 86.25 82.5 84.375 83.125 83.125C85 79.375 88.125 74.375 95 74.375C105 74.375 107.5 83.125 107.5 90.625V128.125C107.5 130 108.75 131.25 110.625 131.25H140.625C142.5 131.25 143.75 130 143.75 128.125V80.625C143.75 55 129.375 39.375 106.875 39.375Z" fill="#149926"/>
					<path d="M19.375 0C8.125 0 0 7.5 0 17.5C0 27.5 8.125 35 18.75 35C30 35 38.125 27.5 38.125 16.875C38.125 7.5 30.625 0 19.375 0Z" fill="#149926"/>
				  </svg>
                </a>
				<?php endif; ?>
				<?php if ($faceboo) : ?>
                    <a class="facebook-link" href="<?php echo $faceboo; ?>" target="_blank">
                        <svg width="32" height="32" viewBox="0 0 32 32" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <path
                            d="M24 2.66675H20C18.2319 2.66675 16.5362 3.36913 15.286 4.61937C14.0357 5.86961 13.3333 7.5653 13.3333 9.33342V13.3334H9.33333V18.6667H13.3333V29.3334H18.6667V18.6667H22.6667L24 13.3334H18.6667V9.33342C18.6667 8.97979 18.8071 8.64065 19.0572 8.39061C19.3072 8.14056 19.6464 8.00008 20 8.00008H24V2.66675Z"
                            stroke="#149926" stroke-width="3" stroke-linecap="round" stroke-linejoin="round" />
                        </svg>
                    </a>
                    <?php endif; ?>
            </div>
          </div>
          <div class="footer-item">
            <?php if($image): ?>
                <?php echo wp_get_attachment_image($image['id'], 'full'); ?>
              <?php endif; ?>
			  <p><span>© <?php echo date("Y"); ?> <?php echo $copyr; ?></span></p>
          </div>
          <div class="footer-item">
            <a class="email-link" href="mailto:<?php echo $email; ?>"><?php echo $email; ?></a>
            <a class="popup-link subscribe-link" href="#steps"><?php echo $button; ?></a>
			<a class="popup-link steps-popup-link" href="#subscribe">Subscribe to get updates</a>
          </div>
        </div>
		<div class="copy-rules">
			<p><span>© <?php echo date("Y"); ?> <?php echo $copyr; ?></span></p>
		</div>
      </div>
    </footer>
  </div>

  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/@fancyapps/ui@5.0/dist/fancybox/fancybox.umd.js"></script>
  <script src="<?php echo get_template_directory_uri(); ?>/js/slick.min.js"></script>
  <script src="<?php echo get_template_directory_uri(); ?>/js/menu.js"></script>
  <script src="<?php echo get_template_directory_uri(); ?>/js/main.js"></script>
  <?php wp_footer(); ?>
</body>

</html>
