<?php
$title = get_field('title_re');
$banner = get_field('banner_re');
$descr = get_field('description_re');
$text = get_field('text_re');
$image_1 = get_field('image_re_1');
$image_2 = get_field('image_re_2');
$image_3 = get_field('image_re_3');
$image_4 = get_field('image_re_4');
$button = get_field('form_button', 'option');
?>

    <div class="reasons">
        <div class="container">
            <div class="reasons-wrapper">
                <div class="reasons-img">
                    <?php if ($banner): ?>
                        <?php echo wp_get_attachment_image($banner['id'], 'full'); ?>
                    <?php endif; ?>
                </div>
                <div class="reasons-descr">
                    <h3><?php echo $title; ?></h3>
                <?php echo $descr; ?>    
                <a class="popup-link" href="#steps"><?php echo $button; ?></a>
                </div>
            </div>
            <div class="butterfly-gallery">
				<h6>Be like a butterfly</h6>
                <p><?php echo $text; ?></p>
                <div class="images">
                    <?php if ($image_1): ?>
                        <?php echo wp_get_attachment_image($image_1['id'], 'full'); ?>
                    <?php endif; ?>
                    <?php if ($image_2): ?>
                        <?php echo wp_get_attachment_image($image_2['id'], 'full'); ?>
                    <?php endif; ?>
                    <?php if ($image_3): ?>
                        <?php echo wp_get_attachment_image($image_3['id'], 'full'); ?>
                    <?php endif; ?>
                    <?php if ($image_4): ?>
                        <?php echo wp_get_attachment_image($image_4['id'], 'full'); ?>
                    <?php endif; ?>
                </div>
            </div>
        </div>
    </div>