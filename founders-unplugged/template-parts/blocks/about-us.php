<?php
	$text = get_field('title_ab');
	$descr = get_field('description_ab');
	$gallery = get_field('gallery_ab');
	$text_social = get_field('text_ab');
	$inst = get_field('instagram_ab');
	$face = get_field('facebook_ab');
	$linkdn = get_field('linkedin_ab');
	$tvit = get_field('x_ab');
?>

    <div class="about">
        <div class="container-fluid">
            <div class="about-wrapper">
                <h2><?php echo $text; ?></h2>
                <?php echo $descr; ?>
            </div>
        </div>
            <div class="gallery-container">
                <div class="full-gallery-slider">

                    <?php if ($gallery) : ?>
                        <?php foreach ($gallery as $item) : 
                    $image = $item['image_gallery_ab']; 
                    if ($image) : ?>
                        <div class="slide-item">
                            <a data-fancybox="gallery" href="<?php echo esc_url($image['url']); ?>">
                                <img src="<?php echo esc_url($image['url']); ?>" alt="<?php echo esc_attr($image['alt']); ?>" loading="lazy">
                            </a>
                        </div>
                        <?php endif; 
                    endforeach; ?>
                    <?php endif; ?>
                
                </div>
                <div class="mini-gallery-slider">
                    <?php if ($gallery) : ?>
                        <?php foreach ($gallery as $item) : 
                    $image = $item['image_gallery_ab']; 
                    if ($image) : ?>
                        <div class="slide-item">
                        <img src="<?php echo esc_url($image['url']); ?>" alt="<?php echo esc_attr($image['alt']); ?>" loading="lazy">
                        </div>
                        <?php endif; 
                    endforeach; ?>
                    <?php endif; ?>                
                </div>
            </div>
            <div class="container-fluid">
                <div class="social-media">
                    <p><?php echo $text_social; ?></p>
                    <div class="links">
                   <?php if ($inst) : ?>
                    <a class="instagram-link" href="<?php echo $inst; ?>" target="_blank">
                        <svg width="32" height="32" viewBox="0 0 32 32" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <path
                            d="M23.3333 8.66675H23.3467M9.33333 2.66675H22.6667C26.3486 2.66675 29.3333 5.65152 29.3333 9.33342V22.6667C29.3333 26.3486 26.3486 29.3334 22.6667 29.3334H9.33333C5.65144 29.3334 2.66667 26.3486 2.66667 22.6667V9.33342C2.66667 5.65152 5.65144 2.66675 9.33333 2.66675ZM21.3333 15.1601C21.4979 16.2697 21.3083 17.403 20.7917 18.3988C20.275 19.3945 19.4575 20.202 18.4555 20.7063C17.4535 21.2107 16.3179 21.3862 15.2104 21.208C14.1028 21.0298 13.0797 20.5069 12.2865 19.7136C11.4932 18.9204 10.9703 17.8972 10.7921 16.7897C10.6139 15.6822 10.7894 14.5466 11.2938 13.5446C11.7981 12.5426 12.6056 11.7251 13.6013 11.2084C14.597 10.6917 15.7303 10.5022 16.84 10.6667C17.9719 10.8346 19.0198 11.362 19.8289 12.1712C20.6381 12.9803 21.1655 14.0282 21.3333 15.1601Z"
                            stroke="#1E1E1E" stroke-width="3" stroke-linecap="round" stroke-linejoin="round" />
                        </svg>
                    </a>
                    <?php endif; ?>
                    <?php if ($face) : ?>
                    <a class="facebook-link" href="<?php echo $face; ?>" target="_blank">
                        <svg width="32" height="32" viewBox="0 0 32 32" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <path
                            d="M24 2.66675H20C18.2319 2.66675 16.5362 3.36913 15.286 4.61937C14.0357 5.86961 13.3333 7.5653 13.3333 9.33342V13.3334H9.33333V18.6667H13.3333V29.3334H18.6667V18.6667H22.6667L24 13.3334H18.6667V9.33342C18.6667 8.97979 18.8071 8.64065 19.0572 8.39061C19.3072 8.14056 19.6464 8.00008 20 8.00008H24V2.66675Z"
                            stroke="#1E1E1E" stroke-width="3" stroke-linecap="round" stroke-linejoin="round" />
                        </svg>
                    </a>
                    <?php endif; ?>
						<?php if ($tvit) : ?>
					<a class="twitter-link" href="<?php echo $tvit; ?>" target="_blank">
						<svg width="1200" height="1227" viewBox="0 0 1200 1227" fill="none" xmlns="http://www.w3.org/2000/svg">
							<g clip-path="url(#clip0_1081_148)">
							<g mask="url(#mask0_1081_148)">
							<path d="M714.163 519.284L1160.89 0H1055.03L667.137 450.887L357.328 0H0L468.492 681.821L0 1226.37H105.866L515.491 750.218L842.672 1226.37H1200L714.137 519.284H714.163ZM569.165 687.828L521.697 619.934L144.011 79.6944H306.615L611.412 515.685L658.88 583.579L1055.08 1150.3H892.476L569.165 687.854V687.828Z" fill="#1E1E1E"/>
							</g>
							</g>
						</svg>
					</a>
						 <?php endif; ?>
						<?php if ($linkdn) : ?>
					<a class="linkid-link" href="<?php echo $linkdn; ?>" target="_blank">
						<svg width="144" height="132" viewBox="0 0 144 132" fill="none" xmlns="http://www.w3.org/2000/svg">
							<path d="M33.125 40H6.25C4.375 40 3.125 41.25 3.125 43.125V128.125C3.125 130 4.375 131.25 6.25 131.25H33.125C35 131.25 36.25 130 36.25 128.125V43.125C36.25 41.25 35 40 33.125 40Z" fill="#1E1E1E"/>
							<path d="M106.875 39.375C96.25 39.375 88.125 43.125 83.125 47.5V43.125C83.125 41.25 81.875 40 80 40H50C48.75 40 48.125 40.625 47.5 41.25C46.875 41.875 46.875 42.5 46.875 43.125C46.875 50 46.875 127.5 46.875 128.125C46.875 128.75 47.5 130 47.5 130C48.125 130.625 48.75 130.625 49.375 130.625H79.375C81.25 130.625 82.5 129.375 82.5 127.5V88.125C82.5 86.25 82.5 84.375 83.125 83.125C85 79.375 88.125 74.375 95 74.375C105 74.375 107.5 83.125 107.5 90.625V128.125C107.5 130 108.75 131.25 110.625 131.25H140.625C142.5 131.25 143.75 130 143.75 128.125V80.625C143.75 55 129.375 39.375 106.875 39.375Z" fill="#1E1E1E"/>
							<path d="M19.375 0C8.125 0 0 7.5 0 17.5C0 27.5 8.125 35 18.75 35C30 35 38.125 27.5 38.125 16.875C38.125 7.5 30.625 0 19.375 0Z" fill="#1E1E1E"/>
						</svg>
					</a>
						 <?php endif; ?>
                    </div>
                </div>
        </div>
    </div>