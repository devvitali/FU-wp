<?php
$image = get_field('image_exp');
$text = get_field('description_exp');
$title_1 = get_field('title_1');
$title_2 = get_field('title_2');
$title_3 = get_field('image_title_exp');
$button = get_field('form_button', 'option');
?>

    <div class="experience">
        <div class="container-fluid">
            <div class="experience-wrapper">
                <a class="popup-link" href="#steps"><?php echo $button; ?></a>
                <h2> <?php echo $title_1; ?><?php if ($title_3): ?>
                            <?php echo wp_get_attachment_image($title_3['id'], 'full'); ?>
                        <?php endif; ?> <?php echo $title_2; ?></h2>
                <?php echo $text; ?>
                <?php if ($image): ?>
                    <?php echo wp_get_attachment_image($image['id'], 'full'); ?>
                <?php endif; ?>
            </div>
        </div>
    </div>