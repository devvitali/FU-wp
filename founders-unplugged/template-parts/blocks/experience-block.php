<?php
$title = get_field('title_exb');
$name_1 = get_field('experience_exb_1');
$name_2 = get_field('experience_exb_2');
$name_3 = get_field('experience_exb_3');
$image_1 = get_field('image_exb_1');
$image_2 = get_field('image_exb_2');
$image_3 = get_field('image_exb_3');
$descr_1 = get_field('description_bl1');
$step_1 = get_field('text_step_1exb_2');
$step_2 = get_field('text_step_2exb_2');
$step_3 = get_field('text_step_3exb_2');
$step_4 = get_field('text_step_4exb_2');
$step_5 = get_field('text_step_5exb_2');
$step_6 = get_field('text_step_6exb_2');
$step_br = get_field('text_brackets_exb_2');
$subtitle_1 = get_field('Subtitle_exb_1b');
$subtitle_2 = get_field('Subtitle_exb_2b');
$descrp2_1 = get_field('description_exb_1de');
$descrp2_2 = get_field('description_exb_2de');
$descr_2more = get_field('description_exb_2de_seemore');
$descrpbl3 = get_field('description_exb_3bl');
$spir_exp = get_field('spir_experience_exb_3bl');
?>

    <div class="experience-anchors">
        <div class="container">
            <h3><?php echo $title; ?></h3>
            <div class="anchors-wrapper">
                <div class="anchors-items">
                <div class="anchor-item">
                    <?php if ($image_1): ?>
                        <?php echo wp_get_attachment_image($image_1['id'], 'full'); ?>
                    <?php endif; ?>
                    <a href="#virtual-experience">
                    <?php echo $name_1; ?>
                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <g clip-path="url(#clip0_1_140)">
                        <path
                            d="M19.9755 9.87454C19.9671 9.85407 19.9526 9.8379 19.9405 9.81969C19.9297 9.80325 19.923 9.78492 19.909 9.7702L13.242 2.76992C13.1144 2.63629 12.9035 2.63156 12.7707 2.75836C12.6372 2.88532 12.632 3.09626 12.7589 3.22955L18.8896 9.66664H0.333333C0.149068 9.66664 0 9.8159 0 9.99997C0 10.184 0.149107 10.3333 0.333333 10.3333H18.8896L12.7589 16.7704C12.632 16.9037 12.6372 17.1147 12.7707 17.2416C12.8351 17.3031 12.9178 17.3336 13.0005 17.3336C13.0884 17.3336 13.1763 17.2989 13.242 17.2301L19.9089 10.2298C19.923 10.215 19.9297 10.1967 19.9405 10.1803C19.9525 10.1621 19.9671 10.1459 19.9754 10.1254C20.0082 10.045 20.0082 9.95501 19.9755 9.87454Z"
                            fill="black" />
                        </g>
                        <defs>
                        <clipPath id="clip0_1_140">
                            <rect width="20" height="20" fill="white" />
                        </clipPath>
                        </defs>
                    </svg>
                    </a>
                </div>
                <div class="anchor-item">
                    <?php if ($image_2): ?>
                        <?php echo wp_get_attachment_image($image_2['id'], 'full'); ?>
                    <?php endif; ?>
                    <a href="#physical-experience">
                    <?php echo $name_2; ?>
                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <g clip-path="url(#clip0_1_140)">
                        <path
                            d="M19.9755 9.87454C19.9671 9.85407 19.9526 9.8379 19.9405 9.81969C19.9297 9.80325 19.923 9.78492 19.909 9.7702L13.242 2.76992C13.1144 2.63629 12.9035 2.63156 12.7707 2.75836C12.6372 2.88532 12.632 3.09626 12.7589 3.22955L18.8896 9.66664H0.333333C0.149068 9.66664 0 9.8159 0 9.99997C0 10.184 0.149107 10.3333 0.333333 10.3333H18.8896L12.7589 16.7704C12.632 16.9037 12.6372 17.1147 12.7707 17.2416C12.8351 17.3031 12.9178 17.3336 13.0005 17.3336C13.0884 17.3336 13.1763 17.2989 13.242 17.2301L19.9089 10.2298C19.923 10.215 19.9297 10.1967 19.9405 10.1803C19.9525 10.1621 19.9671 10.1459 19.9754 10.1254C20.0082 10.045 20.0082 9.95501 19.9755 9.87454Z"
                            fill="black" />
                        </g>
                        <defs>
                        <clipPath id="clip0_1_140">
                            <rect width="20" height="20" fill="white" />
                        </clipPath>
                        </defs>
                    </svg>
                    </a>
                </div>
                <div class="anchor-item">
                    <?php if ($image_3): ?>
                        <?php echo wp_get_attachment_image($image_3['id'], 'full'); ?>
                    <?php endif; ?>
                    <a href="#spiritual-experience">
                    <?php echo $name_3; ?>
                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <g clip-path="url(#clip0_1_140)">
                        <path
                            d="M19.9755 9.87454C19.9671 9.85407 19.9526 9.8379 19.9405 9.81969C19.9297 9.80325 19.923 9.78492 19.909 9.7702L13.242 2.76992C13.1144 2.63629 12.9035 2.63156 12.7707 2.75836C12.6372 2.88532 12.632 3.09626 12.7589 3.22955L18.8896 9.66664H0.333333C0.149068 9.66664 0 9.8159 0 9.99997C0 10.184 0.149107 10.3333 0.333333 10.3333H18.8896L12.7589 16.7704C12.632 16.9037 12.6372 17.1147 12.7707 17.2416C12.8351 17.3031 12.9178 17.3336 13.0005 17.3336C13.0884 17.3336 13.1763 17.2989 13.242 17.2301L19.9089 10.2298C19.923 10.215 19.9297 10.1967 19.9405 10.1803C19.9525 10.1621 19.9671 10.1459 19.9754 10.1254C20.0082 10.045 20.0082 9.95501 19.9755 9.87454Z"
                            fill="black" />
                        </g>
                        <defs>
                        <clipPath id="clip0_1_140">
                            <rect width="20" height="20" fill="white" />
                        </clipPath>
                        </defs>
                    </svg>
                    </a>
                </div>
            </div>

                <div class="anchors-content">
                    <div class="first-anchor" id="virtual-experience">
                        <div class="divider">
                        <div class="line"></div>
                            <img src="<?php echo get_template_directory_uri(); ?>/img/butterflies/butterfly-6.png" alt="butterfly" loading="lazy">
                        <div class="line"></div>
                        </div>
                        <div class="anchor-info">
                            <h3><?php echo $name_1; ?></h3>
                            <?php echo $descr_1; ?>
                        </div>
                    </div>
                    <div class="second-anchor" id="physical-experience">
                        <div class="divider">
                        <div class="line"></div>
                        <img src="<?php echo get_template_directory_uri(); ?>/img/butterflies/butterfly-6.png" alt="butterfly" loading="lazy">
                        <div class="line"></div>
                        </div>
                        <div class="anchor-info">
                        <h3><?php echo $name_2; ?></h3>
                        <div class="steps">
                            <p><?php echo $step_1; ?></p>
                            <img src="<?php echo get_template_directory_uri(); ?>/img/svg/arrow-down.svg" alt="arrow-down">
                            <div class="steps-box">
                            
                            <div class="steps-line">
                                <p><?php echo $step_2; ?></p>
                                <img src="<?php echo get_template_directory_uri(); ?>/img/svg/anchor-arrow.svg" alt="arrow">
                                <p><?php echo $step_3; ?></p>
								<p><span><?php echo $step_br; ?></span></p>
                                <img src="<?php echo get_template_directory_uri(); ?>/img/svg/anchor-arrow.svg" alt="arrow">
                                <p><?php echo $step_4; ?></p>
                            </div>
                            </div>
                            <img src="<?php echo get_template_directory_uri(); ?>/img/svg/arrow-down.svg" alt="arrow-down">
                            <p><?php echo $step_5; ?></p>
                            <p><span><?php echo $step_6; ?></span></p>
                        </div>
                        <div class="list">
                            <div class="list-item">
                            <h4><?php echo $subtitle_1; ?></h4>
                            <ul>
                                <?php if ($descrp2_1) : ?>
                                    <?php foreach ($descrp2_1 as $item) : 
                                        $text = $item['text_description_exb_1de'];
                                        if ($text) : ?>
                                            <li><img src="<?php echo get_template_directory_uri(); ?>/img/svg/close-icon.svg" alt="close-icon"><span><?php echo esc_html($text); ?></span></li>
                                        <?php endif; 
                                    endforeach; ?>
                                <?php endif; ?>
                            </ul>
                            </div>
                            <div class="list-item">
                            <h4><?php echo $subtitle_2; ?></h4>
                            <ul>
                                <?php if ($descrp2_2) : ?>
                                    <?php foreach ($descrp2_2 as $item) : 
                                        $text = $item['text_2_description_exb_2de'];
                                        if ($text) : ?>
                                            <li>
                                                <img src="<?php echo get_template_directory_uri(); ?>/img/svg/check-icon.svg" alt="close-icon">
                                                <span><?php echo esc_html($text); ?></span>
                                            </li>
                                        <?php endif; 
                                    endforeach; ?>
                                <?php endif; ?>
                                <a id="read-more-1" onclick="readMoreFun('hide-text-1',this.id)" class="read-more">
                                see more
                                <svg width="20" height="20" viewBox="0 0 20 20" fill="none"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <g clip-path="url(#clip0_1_140)">
                                    <path
                                        d="M19.9755 9.87454C19.9671 9.85407 19.9526 9.8379 19.9405 9.81969C19.9297 9.80325 19.923 9.78492 19.909 9.7702L13.242 2.76992C13.1144 2.63629 12.9035 2.63156 12.7707 2.75836C12.6372 2.88532 12.632 3.09626 12.7589 3.22955L18.8896 9.66664H0.333333C0.149068 9.66664 0 9.8159 0 9.99997C0 10.184 0.149107 10.3333 0.333333 10.3333H18.8896L12.7589 16.7704C12.632 16.9037 12.6372 17.1147 12.7707 17.2416C12.8351 17.3031 12.9178 17.3336 13.0005 17.3336C13.0884 17.3336 13.1763 17.2989 13.242 17.2301L19.9089 10.2298C19.923 10.215 19.9297 10.1967 19.9405 10.1803C19.9525 10.1621 19.9671 10.1459 19.9754 10.1254C20.0082 10.045 20.0082 9.95501 19.9755 9.87454Z"
                                        fill="black" />
                                    </g>
                                    <defs>
                                    <clipPath id="clip0_1_140">
                                        <rect width="20" height="20" fill="white" />
                                    </clipPath>
                                    </defs>
                                </svg>
                                </a>
                                <div class="hide-text-1 hidden-content">
                                <?php if ($descr_2more) : ?>
                                    <?php foreach ($descr_2more as $item) : 
                                        $text = $item['text_2_description_exb_2de_more'];
                                        if ($text) : ?>
                                            <li>
                                                <img src="<?php echo get_template_directory_uri(); ?>/img/svg/check-icon.svg" alt="close-icon">
                                                <span><?php echo esc_html($text); ?></span>
                                            </li>
                                        <?php endif; 
                                    endforeach; ?>
                                <?php endif; ?>
                                <a onclick="readMoreFun('hide-text-1','read-more-1')" class="read-less">
                                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <path
                                        d="M0.0245319 10.1255C0.0328525 10.1459 0.047423 10.1621 0.0594938 10.1803C0.0703145 10.1968 0.0769947 10.2151 0.0910187 10.2298L6.75796 17.2301C6.88558 17.3637 7.09653 17.3684 7.22935 17.2416C7.36283 17.1147 7.36802 16.9037 7.24106 16.7704L1.11036 10.3334L19.6667 10.3334C19.8509 10.3334 20 10.1841 20 10C20 9.81596 19.8509 9.66669 19.6667 9.66669L1.11036 9.66669L7.24106 3.22961C7.36802 3.09632 7.36283 2.88534 7.22935 2.75838C7.16489 2.69685 7.08219 2.66642 6.99953 2.66642C6.91164 2.66642 6.82374 2.70107 6.758 2.76994L0.091058 9.77021C0.077034 9.78498 0.0703148 9.80326 0.0595331 9.81971C0.0474623 9.83791 0.0329297 9.85408 0.02457 9.87455C-0.00820469 9.95499 -0.00820378 10.045 0.0245319 10.1255Z"
                                        fill="black" />
                                    </svg>
                                    see less
                                </a>
                                </div>
                            </ul>
                            </div>
                        </div>
                        </div>
                    </div>
                    <div class="third-anchor" id="spiritual-experience">
                        <div class="divider">
                        <div class="line"></div>
                        <img src="<?php echo get_template_directory_uri(); ?>/img/butterflies/butterfly-6.png" alt="butterfly" loading="lazy">
                        <div class="line"></div>
                        </div>
                        <div class="anchor-info">
                        <h3><?php echo $name_3; ?></h3>
                        <?php echo $descrpbl3; ?>
                        <div class="butterfly-items">
                            <?php if ($spir_exp) : ?>
                                <?php foreach ($spir_exp as $item) : 
                                    $image = $item['image_spir_experience_exb_3bl']; 
                                    $text = $item['text_spir_experience_exb_3bl']; 
                                    if ($image && $text) : ?>
                                        <div class="butterfly-item">
                                            <img src="<?php echo esc_url($image['url']); ?>" alt="<?php echo esc_attr($image['alt']); ?>" loading="lazy">
                                            <p><?php echo esc_html($text); ?></p>
                                        </div>
                                    <?php endif; 
                                endforeach; ?>
                            <?php endif; ?>
                        </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="anchors-flex">
                <div class="anchors-items">
                    <div class="anchor-item-box">
                        <div class="anchor-item">
                        <?php if ($image_1): ?>
                            <?php echo wp_get_attachment_image($image_1['id'], 'full'); ?>
                        <?php endif; ?>
                        <a class="anchor-link" href="#anchor-1">
                            <?php echo $name_1; ?>
                            <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <g clip-path="url(#clip0_1_140)">
                                <path
                                d="M19.9755 9.87454C19.9671 9.85407 19.9526 9.8379 19.9405 9.81969C19.9297 9.80325 19.923 9.78492 19.909 9.7702L13.242 2.76992C13.1144 2.63629 12.9035 2.63156 12.7707 2.75836C12.6372 2.88532 12.632 3.09626 12.7589 3.22955L18.8896 9.66664H0.333333C0.149068 9.66664 0 9.8159 0 9.99997C0 10.184 0.149107 10.3333 0.333333 10.3333H18.8896L12.7589 16.7704C12.632 16.9037 12.6372 17.1147 12.7707 17.2416C12.8351 17.3031 12.9178 17.3336 13.0005 17.3336C13.0884 17.3336 13.1763 17.2989 13.242 17.2301L19.9089 10.2298C19.923 10.215 19.9297 10.1967 19.9405 10.1803C19.9525 10.1621 19.9671 10.1459 19.9754 10.1254C20.0082 10.045 20.0082 9.95501 19.9755 9.87454Z"
                                fill="black" />
                            </g>
                            <defs>
                                <clipPath id="clip0_1_140">
                                <rect width="20" height="20" fill="white" />
                                </clipPath>
                            </defs>
                            </svg>
                        </a>
                        </div>
                        <div class="first-anchor anchor" id="anchor-1">
                        <div class="divider">
                            <div class="line"></div>
                            <img src="<?php echo get_template_directory_uri(); ?>/img/butterflies/butterfly-6.png" alt="butterfly" loading="lazy">
                            <div class="line"></div>
                        </div>
                        <div class="anchor-info">
                            <h3><?php echo $name_1; ?></h3>
                            <?php echo $descr_1; ?>
                        </div>
                        </div>
                    </div>
                    <div class="anchor-item-box">
                        <div class="anchor-item">
                        <?php if ($image_2): ?>
                            <?php echo wp_get_attachment_image($image_2['id'], 'full'); ?>
                        <?php endif; ?>
                        <a class="anchor-link" href="#anchor-2">
                            <?php echo $name_2; ?>
                            <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <g clip-path="url(#clip0_1_140)">
                                <path
                                d="M19.9755 9.87454C19.9671 9.85407 19.9526 9.8379 19.9405 9.81969C19.9297 9.80325 19.923 9.78492 19.909 9.7702L13.242 2.76992C13.1144 2.63629 12.9035 2.63156 12.7707 2.75836C12.6372 2.88532 12.632 3.09626 12.7589 3.22955L18.8896 9.66664H0.333333C0.149068 9.66664 0 9.8159 0 9.99997C0 10.184 0.149107 10.3333 0.333333 10.3333H18.8896L12.7589 16.7704C12.632 16.9037 12.6372 17.1147 12.7707 17.2416C12.8351 17.3031 12.9178 17.3336 13.0005 17.3336C13.0884 17.3336 13.1763 17.2989 13.242 17.2301L19.9089 10.2298C19.923 10.215 19.9297 10.1967 19.9405 10.1803C19.9525 10.1621 19.9671 10.1459 19.9754 10.1254C20.0082 10.045 20.0082 9.95501 19.9755 9.87454Z"
                                fill="black" />
                            </g>
                            <defs>
                                <clipPath id="clip0_1_140">
                                <rect width="20" height="20" fill="white" />
                                </clipPath>
                            </defs>
                            </svg>
                        </a>
                        </div>
                        <div class="second-anchor anchor" id="anchor-2">
                        <div class="divider">
                            <div class="line"></div>
                            <img src="<?php echo get_template_directory_uri(); ?>/img/butterflies/butterfly-6.png" alt="butterfly" loading="lazy">
                            <div class="line"></div>
                        </div>
                        <div class="anchor-info">
                            <h3><?php echo $name_2; ?></h3>
                            <div class="steps">
                            <p><?php echo $step_1; ?></p>
                            <img src="<?php echo get_template_directory_uri(); ?>/img/svg/arrow-down.svg" alt="arrow-down">
                            <div class="steps-box">
                                <div class="steps-line">
                                <p><?php echo $step_2; ?></p>
                                <img src="<?php echo get_template_directory_uri(); ?>/img/svg/anchor-arrow.svg" alt="arrow">
                                <p><?php echo $step_3; ?></p>
								<p><span><?php echo $step_br; ?></span></p>
                                <img src="<?php echo get_template_directory_uri(); ?>/img/svg/anchor-arrow.svg" alt="arrow">
                                <p><?php echo $step_4; ?></p>
                                </div>
                            </div>
                            <img src="<?php echo get_template_directory_uri(); ?>/img/svg/arrow-down.svg" alt="arrow-down">
                            <p><?php echo $step_5; ?></p>
                            <p><span><?php echo $step_6; ?></span></p>
                            </div>
                            <div class="list">
                            <div class="list-item">
                                <h4><?php echo $subtitle_1; ?></h4>
                                <ul>
                                    <?php if ($descrp2_1) : ?>
                                        <?php foreach ($descrp2_1 as $item) : 
                                            $text = $item['text_description_exb_1de'];
                                            if ($text) : ?>
                                                <li><img src="<?php echo get_template_directory_uri(); ?>/img/svg/close-icon.svg" alt="close-icon"><span><?php echo esc_html($text); ?></span></li>
                                            <?php endif; 
                                        endforeach; ?>
                                    <?php endif; ?>
                                </ul>
                            </div>
                            <div class="list-item">
                                <h4><?php echo $subtitle_2; ?></h4>
                                <ul>
                                <?php if ($descrp2_2) : ?>
                                    <?php foreach ($descrp2_2 as $item) : 
                                        $text = $item['text_2_description_exb_2de'];
                                        if ($text) : ?>
                                            <li>
                                                <img src="<?php echo get_template_directory_uri(); ?>/img/svg/check-icon.svg" alt="close-icon">
                                                <span><?php echo esc_html($text); ?></span>
                                            </li>
                                        <?php endif; 
                                    endforeach; ?>
                                <?php endif; ?>
                                <a id="read-more-4" onclick="readMoreFun('hide-text-4',this.id)" class="read-more">
                                    see more
                                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <g clip-path="url(#clip0_1_140)">
                                        <path
                                        d="M19.9755 9.87454C19.9671 9.85407 19.9526 9.8379 19.9405 9.81969C19.9297 9.80325 19.923 9.78492 19.909 9.7702L13.242 2.76992C13.1144 2.63629 12.9035 2.63156 12.7707 2.75836C12.6372 2.88532 12.632 3.09626 12.7589 3.22955L18.8896 9.66664H0.333333C0.149068 9.66664 0 9.8159 0 9.99997C0 10.184 0.149107 10.3333 0.333333 10.3333H18.8896L12.7589 16.7704C12.632 16.9037 12.6372 17.1147 12.7707 17.2416C12.8351 17.3031 12.9178 17.3336 13.0005 17.3336C13.0884 17.3336 13.1763 17.2989 13.242 17.2301L19.9089 10.2298C19.923 10.215 19.9297 10.1967 19.9405 10.1803C19.9525 10.1621 19.9671 10.1459 19.9754 10.1254C20.0082 10.045 20.0082 9.95501 19.9755 9.87454Z"
                                        fill="black" />
                                    </g>
                                    <defs>
                                        <clipPath id="clip0_1_140">
                                        <rect width="20" height="20" fill="white" />
                                        </clipPath>
                                    </defs>
                                    </svg>
                                </a>
                                <div class="hide-text-4 hidden-content">
                                    <?php if ($descr_2more) : ?>
                                        <?php foreach ($descr_2more as $item) : 
                                            $text = $item['text_2_description_exb_2de_more'];
                                            if ($text) : ?>
                                                <li>
                                                    <img src="<?php echo get_template_directory_uri(); ?>/img/svg/check-icon.svg" alt="close-icon">
                                                    <span><?php echo esc_html($text); ?></span>
                                                </li>
                                            <?php endif; 
                                        endforeach; ?>
                                    <?php endif; ?>
                                    <a onclick="readMoreFun('hide-text-4','read-more-4')" class="read-less">
                                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none"
                                        xmlns="http://www.w3.org/2000/svg">
                                        <path
                                        d="M0.0245319 10.1255C0.0328525 10.1459 0.047423 10.1621 0.0594938 10.1803C0.0703145 10.1968 0.0769947 10.2151 0.0910187 10.2298L6.75796 17.2301C6.88558 17.3637 7.09653 17.3684 7.22935 17.2416C7.36283 17.1147 7.36802 16.9037 7.24106 16.7704L1.11036 10.3334L19.6667 10.3334C19.8509 10.3334 20 10.1841 20 10C20 9.81596 19.8509 9.66669 19.6667 9.66669L1.11036 9.66669L7.24106 3.22961C7.36802 3.09632 7.36283 2.88534 7.22935 2.75838C7.16489 2.69685 7.08219 2.66642 6.99953 2.66642C6.91164 2.66642 6.82374 2.70107 6.758 2.76994L0.091058 9.77021C0.077034 9.78498 0.0703148 9.80326 0.0595331 9.81971C0.0474623 9.83791 0.0329297 9.85408 0.02457 9.87455C-0.00820469 9.95499 -0.00820378 10.045 0.0245319 10.1255Z"
                                        fill="black" />
                                    </svg>
                                    see less
                                    </a>
                                </div>
                                </ul>
                            </div>
                            </div>
                        </div>
                        </div>
                    </div>
                    <div class="anchor-item-box">
                        <div class="anchor-item">
                        <?php if ($image_3): ?>
                            <?php echo wp_get_attachment_image($image_3['id'], 'full'); ?>
                        <?php endif; ?>
                        <a class="anchor-link" href="#anchor-3">
                            <?php echo $name_3; ?>
                            <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <g clip-path="url(#clip0_1_140)">
                                <path
                                d="M19.9755 9.87454C19.9671 9.85407 19.9526 9.8379 19.9405 9.81969C19.9297 9.80325 19.923 9.78492 19.909 9.7702L13.242 2.76992C13.1144 2.63629 12.9035 2.63156 12.7707 2.75836C12.6372 2.88532 12.632 3.09626 12.7589 3.22955L18.8896 9.66664H0.333333C0.149068 9.66664 0 9.8159 0 9.99997C0 10.184 0.149107 10.3333 0.333333 10.3333H18.8896L12.7589 16.7704C12.632 16.9037 12.6372 17.1147 12.7707 17.2416C12.8351 17.3031 12.9178 17.3336 13.0005 17.3336C13.0884 17.3336 13.1763 17.2989 13.242 17.2301L19.9089 10.2298C19.923 10.215 19.9297 10.1967 19.9405 10.1803C19.9525 10.1621 19.9671 10.1459 19.9754 10.1254C20.0082 10.045 20.0082 9.95501 19.9755 9.87454Z"
                                fill="black" />
                            </g>
                            <defs>
                                <clipPath id="clip0_1_140">
                                <rect width="20" height="20" fill="white" />
                                </clipPath>
                            </defs>
                            </svg>
                        </a>
                        </div>
                        <div class="third-anchor anchor" id="anchor-3">
                        <div class="divider">
                            <div class="line"></div>
                            <img src="<?php echo get_template_directory_uri(); ?>/img/butterflies/butterfly-6.png" alt="butterfly" loading="lazy">
                            <div class="line"></div>
                        </div>
                        <div class="anchor-info">
                            <h3><?php echo $name_3; ?></h3>
                            <?php echo $descrpbl3; ?>
                            <div class="butterfly-items">
                                <?php if ($spir_exp) : ?>
                                    <?php foreach ($spir_exp as $item) : 
                                        $image = $item['image_spir_experience_exb_3bl']; 
                                        $text = $item['text_spir_experience_exb_3bl']; 
                                        if ($image && $text) : ?>
                                            <div class="butterfly-item">
                                                <img src="<?php echo esc_url($image['url']); ?>" alt="<?php echo esc_attr($image['alt']); ?>" loading="lazy">
                                                <p><?php echo esc_html($text); ?></p>
                                            </div>
                                        <?php endif; 
                                    endforeach; ?>
                                <?php endif; ?>
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>