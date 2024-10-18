<?php
$image = get_field('image_tes');
$text = get_field('title_tes');
$testimonials = get_field('testimonials');
?>

    <div class="reviews">
        <div class="container">
            <h3><?php echo $text; ?></h3>
            <div class="reviews-slider">
                <?php if ($testimonials) : ?>
                        <?php foreach ($testimonials as $testimonial) : 
                            $review = $testimonial['review_testimonials'];
                            $author = $testimonial['author_testimonials'];
                            if ($review && $author) : ?>
                                <div class="slide">
                                    <p><?php echo esc_html($review); ?></p>
                                    <p><span>~ <?php echo esc_html($author); ?></span></p>
                                </div>
                            <?php endif; 
                        endforeach; ?>
                <?php endif; ?>
            </div>
            <div class="slider-arrows"></div>
            <?php if ($image): ?>
                <?php echo wp_get_attachment_image($image['id'], 'full'); ?>
            <?php endif; ?>
        </div>
    </div>